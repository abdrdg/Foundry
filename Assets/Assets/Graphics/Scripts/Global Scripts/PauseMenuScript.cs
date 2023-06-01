using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public AudioSource _bgm;
    public GameObject pauseButton;

    void Awake()
    {
        pauseButton = GameObject.FindGameObjectWithTag("Pause");
        _bgm =  GameObject.FindGameObjectWithTag("AgilityBGM").GetComponent<AudioSource>();
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        _bgm.Play();
        pauseButton.SetActive(true);

       Destroy(gameObject);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        pauseButton.SetActive(true);
        Destroy(gameObject);
    }
}
