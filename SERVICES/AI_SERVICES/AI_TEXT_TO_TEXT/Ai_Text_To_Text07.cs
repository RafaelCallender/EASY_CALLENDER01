using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using LLama;
using LLama.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System.Diagnostics;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{
    public class Ai_Text_To_Text07
    {


        public string Ai_text_generation01()
        {
            var runnerProjectPath = FindRunnerProjectPath();
            if (runnerProjectPath is null)
            {
                return $"Could not locate the .NET 8 AI runner project.\n" +
                       $"Run EASYCONSOLE/AI_RUNNER/EASYAI_RUNNER.csproj directly.\n"

                   ;
            }
            var startInfo = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = Path.GetDirectoryName(runnerProjectPath)!,
                UseShellExecute = false
            };
            startInfo.ArgumentList.Add("run");
            startInfo.ArgumentList.Add("--project");
            startInfo.ArgumentList.Add(runnerProjectPath);
            startInfo.ArgumentList.Add("--");
            startInfo.ArgumentList.Add(File_Manger05.text_to_text_local01_gguf);

            try
            {
                using var runner = Process.Start(startInfo);
                if (runner is null)
                    return "Failed to start the .NET 8 AI runner process.";

                runner.WaitForExit();
                return runner.ExitCode == 0
                    ? "The .NET 8 AI runner exited successfully."
                    : $"The .NET 8 AI runner exited with code {runner.ExitCode}.";
            }
            catch (Exception ex)
            {
                return $"Failed to start the .NET 8 AI runner.\n{ex}";
            }
        }

        private static string? FindRunnerProjectPath()
        {
            foreach (var root in new[] { AppContext.BaseDirectory, Environment.CurrentDirectory })
            {
                var directory = new DirectoryInfo(root);
                while (directory is not null)
                {
                    var projectPaths = new[]
                    {
                        Path.Combine(
                            directory.FullName,
                            "AI_RUNNER",
                            "EASYAI_RUNNER.csproj"),
                        Path.Combine(
                            directory.FullName,
                            "EASYCONSOLE",
                            "AI_RUNNER",
                            "EASYAI_RUNNER.csproj")
                    };

                    foreach (var projectPath in projectPaths)
                    {
                        if (File.Exists(projectPath))
                            return Path.GetFullPath(projectPath);
                    }

                    directory = directory.Parent;
                }
            }

            return null;
        }

    }
}
