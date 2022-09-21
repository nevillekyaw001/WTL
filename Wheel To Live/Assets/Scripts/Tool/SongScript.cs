using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongScript : MonoBehaviour
{
    public AudioClip Song1;//<---drag mp3 into the inspector here
    public AudioClip Song2; //<---drag  mp3#2 into the inspector here
    public AudioClip Song3;
    AudioSource audior;

    IEnumerator Start()
    { 
        audior = GetComponent<AudioSource>();
        audior.Play();
        yield return new WaitForSeconds(57);
        audior.clip = Song2;
        audior.Play();
        yield return new WaitForSeconds(62);
        audior.clip = Song3;
        audior.Play();
    }

    // now you should be able to say this anywhere else in your code
    
}
