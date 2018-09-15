using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSound : MonoBehaviour
{
    public AudioSource rmLetter;
   

    public void removeLetter()
    {
        rmLetter.Play();
    }
    
}
