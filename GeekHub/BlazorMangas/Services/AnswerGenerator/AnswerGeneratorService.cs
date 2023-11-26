using OpenAI_API;
using OpenAI_API.Completions;

namespace BlazorMangas.Services.AnswerGenerator
{
    public class AnswerGeneratorService : IAnswerGeneratorService
    {
        public async Task<string> GenerateAnswer(string prompt)
        {
            string apiKey = "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";
            string answer = string.Empty;

            var openai = new OpenAIAPI(apiKey);
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt = prompt;
            completion.MaxTokens = 4000;
            var result = await openai.Completions.CreateCompletionsAsync(completion);
            if (result != null)
            {
                foreach (var item in result.Completions)
                {
                    answer = item.Text;
                }
            }
            return answer;
        }
    }
}
