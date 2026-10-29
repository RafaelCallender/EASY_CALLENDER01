using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using LLama;
using LLama.Common;
using LLama.Native;
using System;
using System.Collections.Generic;
using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using Microsoft.Maui.Storage;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_HELPER
{
    public class Ai_Helper01
    {
  
        private readonly Dictionary<string, string> _chunkCache = new();
        private static bool _chunksLoaded = false;
        private static List<string> ContentChunks = new();
        public ModelParams? _parameters;
        public LLamaWeights? _model;
        public string filepath { get; private set; } = File_Manger05.text_to_text_local01_gguf;
        private readonly SemaphoreSlim _modelLock = new(1, 1);
        private static readonly HashSet<string> StopWords = new()
        {
            "the", "and", "that", "with", "from", "this", "have",
            "were", "shall", "unto", "them", "they", "their"
        };

        public string RetrieveContext(string question, Action? chunkLoader, int maxChunks = 3)
        {
            if (!_chunksLoaded && chunkLoader != null)
            {
                chunkLoader();
                _chunksLoaded = true;
            }

            if (ContentChunks.Count == 0)
                return string.Empty;

            var keywords = question
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.Trim().ToLowerInvariant())
                .Where(w => w.Length > 3 && !StopWords.Contains(w))
                .Distinct()
                .ToList();

            if (keywords.Count == 0)
                return string.Empty;

            var rankedChunks = ContentChunks
                .Select(chunk => new
                {
                    Text = chunk,
                    Score = keywords.Sum(k =>
                        chunk.Contains(k, StringComparison.OrdinalIgnoreCase) ? 1 : 0)
                })
                .Where(x => x.Score > 0)
                .OrderByDescending(x => x.Score)
                .Take(maxChunks)
                .Select(x => x.Text);

            return string.Join("\n\n", rankedChunks);
        }

        public async Task LoadModelAsync()
        {
            if (_model != null)
                return;

            await _modelLock.WaitAsync().ConfigureAwait(false);
            try
            {
                if (_model != null)
                    return;

                var modelPath = await GetModelPathAsync().ConfigureAwait(false);
                _parameters = new ModelParams(modelPath)
                {
                    ContextSize = 4096,
                    GpuLayerCount = 0
                };

                _model = await Task.Run(() => LLamaWeights.LoadFromFile(_parameters))
                    .ConfigureAwait(false);
            }
            finally
            {
                _modelLock.Release();
            }
        }

        public void LoadModel()
        {
            LoadModelAsync().GetAwaiter().GetResult();
        }

        public async Task<string> GetModelPathAsync()
        {
            if (File.Exists(filepath))
            {
                return filepath;
            }

            const string assetName = "text_to_text_local01.gguf";
            string modelPath = Path.Combine(FileSystem.AppDataDirectory, assetName);
            if (File.Exists(modelPath))
            {
                filepath = modelPath;
                return filepath;
            }

            Directory.CreateDirectory(FileSystem.AppDataDirectory);
            string temporaryPath = $"{modelPath}.{Guid.NewGuid():N}.tmp";

            try
            {
                await using Stream modelAsset =
                    await FileSystem.OpenAppPackageFileAsync(assetName).ConfigureAwait(false);
                await using (var destination = new FileStream(
                    temporaryPath,
                    FileMode.CreateNew,
                    FileAccess.Write,
                    FileShare.None,
                    bufferSize: 81920,
                    useAsync: true))
                {
                    await modelAsset.CopyToAsync(destination).ConfigureAwait(false);
                }

                File.Move(temporaryPath, modelPath);
                filepath = modelPath;
                return filepath;
            }
            finally
            {
                if (File.Exists(temporaryPath))
                {
                    File.Delete(temporaryPath);
                }
            }

        }



    }
}
