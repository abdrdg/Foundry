using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    protected bool isPaused = false;
    public GameObject prefab;
    public GameObject gotoObject;
    public GameObject pauseButton;
    public AudioSource _bgm;

    public void OnClick()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0.0f;
            _bgm.Pause();
            isPaused = true;

            GameObject pauseMenu = Instantiate(prefab,new Vector3(0,0,0),Quaternion.identity);
            pauseMenu.transform.SetParent(gotoObject.transform);

            pauseButton.SetActive(false);

        
        }
        else
        {
            Time.timeScale = 1.0f;
            _bgm.Play();
            isPaused = false;
            pauseButton.SetActive(true);
        }
    }
}
