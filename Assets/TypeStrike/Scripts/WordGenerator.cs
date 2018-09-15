using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

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
    
    void Start()
    {
        // Set up the Editor before calling into the Database
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://unitywords-ce250.firebaseio.com/");

        // Get the root reference location of the Database
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

        Debug.Log(reference.Key);
    }
}
