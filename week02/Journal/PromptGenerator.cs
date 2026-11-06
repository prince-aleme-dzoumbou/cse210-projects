
public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the best part of my day?",
            "What did I learn today?",
            "Who made me smile today?",
            "What challenge did I overcome today?",
            "What am I grateful for today?",
            "What would I like to improve tomorrow?",
            "What is something I can do to make today better?",
        };

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}