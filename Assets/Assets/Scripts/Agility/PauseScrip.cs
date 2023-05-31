using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScrip : MonoBehaviour
{
    protected bool isPaused = false;
    public AudioSource _bgm;

    public void OnClick()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0.0f;
            _bgm.Pause();
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1.0f;
            _bgm.Play();
            isPaused = false;
        }
    }
}
