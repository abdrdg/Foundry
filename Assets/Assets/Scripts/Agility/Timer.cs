using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class Timer : MonoBehaviour
{
    public GameObject _timerRef;
    public TextMeshProUGUI timer;
    public float showntime = 30, time;

    public GameObject _gameOverUI;
    public GameObject _playAgainButton;
    public GameObject _pauseButtonUI;
  

    public bool _isAgilityClear = false;
    // Start is called before the first frame update
    void Start()
    {  
        if(_timerRef == null )
        {
            _timerRef = GameObject.Find("Timer");
        }
        timer = _timerRef.gameObject.GetComponent<TextMeshProUGUI>();
        timer.text = showntime.ToString();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer != null)
        {
            time = Time.deltaTime;
            showntime -= time;
            timer.text = Mathf.Round(showntime).ToString();
            if (Mathf.Sign(showntime) == -1)
            {
                _isAgilityClear = true;
                timer.text = "Done";
            }
            
        }
        Debug.Log(time);

        if(_isAgilityClear)
        {
            if (_gameOverUI != null && _playAgainButton != null)
            {
                ShowUI("You Win! Great Job!");
                Time.timeScale = 0f;
            }
        }
    }

    void ShowUI(string showText)
    {
        _gameOverUI.SetActive(true);
        _playAgainButton.SetActive(true);
        _gameOverUI.GetComponent<TextMeshProUGUI>().text = showText;
        _pauseButtonUI.SetActive(false);
    }
}
