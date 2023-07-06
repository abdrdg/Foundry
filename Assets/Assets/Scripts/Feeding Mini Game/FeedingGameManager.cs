using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FeedingGameManager : MonoBehaviour
{
    public int goodFood;
    public int badFood;
    public float countdownTime = 600;
    private bool Active = true;
    private bool Stop = false;
    public static FeedingGameManager timer;
    public AudioSource BGM;
    public TMP_Text goodScore;
    public TMP_Text Timer;
    public TMP_Text badScore;
    public TMP_Text winText;
    public TMP_Text loseText;
    public Button button;
    public Sprite goodReact;
    public Sprite badReact;
    public bool changedSprite;
    public GameObject foodBowl;
    public FoodSpawner foodSpawner;
    public GetDogSO dogStats;
    public DataManager dogManager;
    private bool statsAdded;
    private void Start()
    {
        Time.timeScale = 1;
        winText.enabled = false;
        loseText.enabled = false;
        button.gameObject.SetActive(false);
        BGM.Play();
        statsAdded = false;
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
            Timer.text = niceTime;

            if (countdownTime <= 0)
            {
                foodBowl.SetActive(false);
                Active = false;
                countdownTime = 0;
                Timer.text = "00:00";
                Stop = true;
                Time.timeScale = 0;
                button.gameObject.SetActive(true);
                WinLoseConditions();
            }
        }
        if (Stop)
        {
            Stop = false;
        }
    }

    public void OutOfTime()
    {
        SceneManager.LoadScene(0);
    }

    public void UpdateGoodScore()
    {
        goodFood++;
        goodScore.text = ":" + goodFood.ToString();
    }
    public void UpdateBadScore()
    {
        badFood++;
        badScore.text = ":" + badFood.ToString();
    }

    public void WinLoseConditions()
    {
        if (goodFood > badFood)
        {
            Debug.Log("Win");
            winText.enabled = true;
            TurnOffOtherUI();
            if (statsAdded == false)
            {
                dogStats.ReturnDogData().Energy += 2;
                dogStats.SaveDogData();
                statsAdded = true;
            }
        }
        else if (goodFood < badFood)
        {
            Debug.Log("Lose");
            loseText.enabled = true;
            TurnOffOtherUI();
        }
        else
        {
            Debug.Log("Lose");
            loseText.enabled = true;
            TurnOffOtherUI();
        }
    }

    public void TurnOffOtherUI()
    {
        foodSpawner.HideAllFoods();
        goodScore.enabled = false;
        Timer.enabled = false;
        badScore.enabled = false;
    }

}
