using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_HELPER;
using System.Text;
using LLama;
using LLama.Common;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{
    public class Ai_Text_To_Text01
    {
        private static Ai_Helper01 Ai_H01 = new Ai_Helper01();

        public Ai_Text_To_Text01()
        {
        }

        public async Task<string> text_to_text_generator01(string input)
        {
            await Ai_H01.LoadModelAsync();
            using var context = Ai_H01._model!.CreateContext(Ai_H01._parameters!);
            var executor = new InteractiveExecutor(context);

            string prompt = $"""
try to answer the following questions to the best of your ability. You can use the internet to find the answers,or saved text but you must only use reliable sources. If you don't know the answer, say you don't know. question is

### SAVED TEXT


Question:
{input}

Answer:
""";

            var inferenceParams = new InferenceParams
            {
                MaxTokens = 512,
            };

            var result = new StringBuilder();

            await foreach (var token in executor.InferAsync(prompt, inferenceParams))
            {
                result.Append(token);
            }

            return result.ToString().Trim();
        }

        public async Task<string> text_to_text_generator02(string input)
        {
            await Ai_H01.LoadModelAsync();
            using var context = Ai_H01._model!.CreateContext(Ai_H01._parameters!);
            var executor = new InteractiveExecutor(context);

            string prompt = $"""
You are a senior C# net10.0 software developer assistant working inside an existing production codebase.

Your role:
- Provide precise, maintainable, and production-ready C# net10.0 solutions.
- Follow the existing architecture and coding style from the provided project context.
- Do not invent files, classes, or methods that are not present unless explicitly necessary.

==================== PROJECT CONTEXT ====================

==========================================================

==================== SAVED DEVELOPER NOTES ===============

==========================================================

QUESTION:
{input}

FINAL ANSWER:
""";

            var inferenceParams = new InferenceParams
            {
                MaxTokens = 512,
            };

            var result = new StringBuilder();

            await foreach (var token in executor.InferAsync(prompt, inferenceParams))
            {
                result.Append(token);
            }

            return result.ToString().Trim();
        }

        public async Task<string> text_to_text_generator03(string input)
        {
            await Ai_H01.LoadModelAsync();
            using var context = Ai_H01._model!.CreateContext(Ai_H01._parameters!);
            var executor = new InteractiveExecutor(context);

            string prompt = $"""
You are a senior net8.0 .cshtml software developer assistant working inside an existing production codebase.

Your role:
- Provide precise, maintainable, and production-ready C# and cshtml solutions.
- Follow the existing architecture and coding style from the provided project context.
- Do not invent files, classes, or methods that are not present unless explicitly necessary.

==================== PROJECT CONTEXT ====================


==========================================================

==================== SAVED DEVELOPER NOTES ===============

==========================================================

QUESTION:
{input}

FINAL ANSWER:
""";

            var inferenceParams = new InferenceParams
            {
                MaxTokens = 512,
            };

            var result = new StringBuilder();

            await foreach (var token in executor.InferAsync(prompt, inferenceParams))
            {
                result.Append(token);
            }

            return result.ToString().Trim();
        }
    }
}
