using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public AudioSource _bgm;
    public GameObject pauseButton;

    void Awake()
    {
        pauseButton = GameObject.FindGameObjectWithTag("Pause");
        _bgm = GameObject.FindGameObjectWithTag("AgilityBGM").GetComponent<AudioSource>();
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        _bgm.Play();
        pauseButton.SetActive(true);
        Invoke("DestroyObject", 0.1f);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        pauseButton.SetActive(true);
        Invoke("DestroyObject", 0.1f);
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
}
