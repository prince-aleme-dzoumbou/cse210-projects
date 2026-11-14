using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create the scripture text
        string text =
            "Trust in the Lord with all your heart and " +
            "lean not on your own understanding; in all " +
            "your ways submit to him, and he will make " +
            "your paths straight.";

        // Create the Scripture object
        Scripture scripture = new Scripture(reference, text);

        int wordsToHide = 3;

        // Main program loop
        while (true)
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine("       SCRIPTURE MEMO");
            Console.WriteLine("==================================");
            Console.WriteLine();

            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Calculate progress
            int totalWords = scripture.GetTotalWordCount();
            int remainingWords = scripture.GetWordsRemaining();

            int hiddenWords = totalWords - remainingWords;

            double progress = (double)hiddenWords / totalWords * 100;

            Console.WriteLine($"Memorization progress: {progress:F0}%");
            Console.WriteLine($"Words remaining: {remainingWords}/{totalWords}");
            Console.WriteLine();

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You have hidden every word.");
                Console.WriteLine("Memorization session completed!");

                break;
            }

            // Ask the user what to do
            Console.WriteLine(
                "Press ENTER to hide more words or type 'quit' to exit."
            );

            string input = Console.ReadLine() ?? "";

            if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Thank you for practicing!");
                break;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                scripture.HideRandomWords(wordsToHide);
            }
        }
    }
}