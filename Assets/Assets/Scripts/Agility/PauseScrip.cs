using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScrip : MonoBehaviour
{
    protected bool isPaused = false;
    public GameObject prefab;
    public GameObject gotoObject;
    public GameObject pauseButton;
    public AudioSource _bgm;
    

    public void OnClick()
    {
            Time.timeScale = 0.0f;
            _bgm.Pause();
            isPaused = true;

            GameObject pauseMenu = Instantiate(prefab,new Vector3(549,262,0),Quaternion.identity);
            pauseMenu.transform.SetParent(gotoObject.transform);
            pauseButton.SetActive(false);
    }
}
