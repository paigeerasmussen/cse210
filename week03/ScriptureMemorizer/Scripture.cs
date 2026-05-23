using System;
using System.Security.Cryptography;

class Scripture
{
    private List<Word> _word = new List<Word>();
    private Reference _reference;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _word.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int hidden = 0;
        int visible = _word.Count(word => !word.IsHidden());
        int goal = Math.Min(numberToHide, visible);

        while (hidden < goal)
        {
            int index = RandomNumberGenerator.GetInt32(_word.Count);
            Word word = _word[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scripture = $"{_reference.GetDisplayText()}";

        foreach (Word word in _word)
        {
            scripture += " " + word.GetDisplayText();
        }
        return scripture;
    }

    public void RestartProgram()
    {
        foreach (Word word in _word)
        {
            word.Show();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}