namespace BlazorMangas.Services.AnswerGenerator
{
    public interface IAnswerGeneratorService
    {
        Task<string> GenerateAnswer(string prompt);
    }
}
