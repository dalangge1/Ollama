namespace Ollama.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetCompletion()
    {
#if DEBUG
        await using var container = await Environment.PrepareAsync(EnvironmentType.Local, "llama3.2");
#else
        await using var container = await Environment.PrepareAsync(EnvironmentType.Container, "llama3.2");
#endif

        IList<long>? context = null;
        var enumerable = container.ApiClient.Completions.GenerateCompletionAsync("llama3.2", "answer 5 random words");
        await foreach (var response in enumerable)
        {
            Console.WriteLine($"> {response.Response}");
            
            context = response.Context;
        }
        
        var lastResponse = await container.ApiClient.Completions.GenerateCompletionAsync("llama3.2", "answer 123", stream: false, context: context).WaitAsync();
        Console.WriteLine(lastResponse.Response);
    }
}