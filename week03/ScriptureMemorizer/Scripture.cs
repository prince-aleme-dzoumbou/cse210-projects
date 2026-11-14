using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] words = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    // Hide random visible words
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int randomIndex = _random.Next(visibleWords.Count);

            Word selectedWord = visibleWords[randomIndex];

            selectedWord.Hide();

            visibleWords.RemoveAt(randomIndex);
        }
    }

    // Get the display text for the scripture
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    // Check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    // Count visible words
    public int GetWordsRemaining()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }

    // Count all words
    public int GetTotalWordCount()
    {
        return _words.Count;
    }
}