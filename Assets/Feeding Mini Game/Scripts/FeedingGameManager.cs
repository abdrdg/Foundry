using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FeedingGameManager : MonoBehaviour
{
    public int FoodInBowl;
    public float countdownTime = 600;
    private bool Active = true;
    private bool Stop = false;
    public static FeedingGameManager timer;
    public TMP_Text Text;
    public TMP_Text Score;
    public Canvas button;

    private void Start()
    {
        Time.timeScale = 1;
        button.gameObject.SetActive(false);
    }

    void Update()
    {
        timeFunction();
    }

    private void timeFunction()
    {
        if (Active)
        {
            countdownTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(countdownTime / 60F);
            int seconds = Mathf.FloorToInt(countdownTime - minutes * 60);
            string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            Text.text = niceTime;

            if (countdownTime <= 0)
            {
                Active = false;
                countdownTime = 0;
                minutes = 0;
                seconds = 0;
                Text.text = "00:00";
                Stop = true;
                Time.timeScale = 0;
                button.gameObject.SetActive(true);
            }
        }
        if (Stop)
        {
            Stop = false;
        }
    }

    public void outOfTime()
    {
        SceneManager.LoadScene("FoodBowl");
    }

    public void UpdateScore()
    {
        FoodInBowl++;
        Score.text = "Score: " + FoodInBowl.ToString();
    }
}
