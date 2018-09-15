using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WordDisplaye : MonoBehaviour
{
    public TextMeshPro text;
    public WordSound wordSound;

    [RangeAttribute(.1f, 4f)]
    public float fallSpeed = 1f;

    public void SetWord(string word)
    {
        text = GetComponent<TextMeshPro>();
        text.SetText(word);
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
        wordSound.removeLetter();
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        // move words down each frame
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0);
    }
}
