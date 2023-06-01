using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    public AudioClip BadAudio;
    public AudioClip GoodAudio;
    // Start is called before the first frame update

    public void PlayBadAudio()
    {
        
        this.GetComponent<AudioSource>().clip = BadAudio;
        this.GetComponent<AudioSource>().Play();
    }

    public void PlayGoodAudio()
    {
        this.GetComponent<AudioSource>().clip = GoodAudio;
        this.GetComponent<AudioSource>().Play();
    }
}
