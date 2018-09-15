using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;

    private WordDisplaye display;

    /// <summary>
    ///  Word Object Constructor
    /// </summary>
    /// <param name="_word">string</param>
    /// <param name="_display">Displaye word</param>
    public Word (string _word, WordDisplaye _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    /// <summary>
    /// 
    /// </summary>
    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();
        // Remove letter on screen
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            // remove word on screen
            display.RemoveWord();
        }
        return wordTyped;
    }
}
