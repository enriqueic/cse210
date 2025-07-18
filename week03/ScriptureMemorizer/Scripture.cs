using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList;
    public Scripture(Reference reference, String text)
    {
        _reference = reference;
        _wordList = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _wordList.Add(new Word(word));
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _wordList)
        {
            if (word.IsHidden())
            {
                String underscores = new string('_', word.GetDisplayText().Length);
                displayText += underscores + " ";
            }
            else
            {
                displayText += word.GetDisplayText() + " ";
            }
        }
        return displayText;
    }



    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new();
        foreach (Word word in _wordList)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new();
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(_wordList.Count);
            Word wordToHide = _wordList[index];
            if (!wordToHide.IsHidden())
            {
                wordToHide.Hide();
            }
            else
            {
                i--; // Retry if the word is already hidden
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}