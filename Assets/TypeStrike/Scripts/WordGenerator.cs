using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour
{
    // list of words we generate from. TODO, Update with more words and random generation
    private static string[] wordList = { "Words", "Nerds", "Turds", "Birds", "Herds" };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
  
}
