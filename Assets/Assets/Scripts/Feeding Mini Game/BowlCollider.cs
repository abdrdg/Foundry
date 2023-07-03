using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowlCollider : MonoBehaviour
{
    public FeedingGameManager gameManager;
    public SFXPlayer SFX;
    public Animator dogControl;
    //public FoodData data;
    public FoodSpawner spawner;



    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Good Food"))
        {
            gameManager.UpdateGoodScore();
            spawner.goodPool.Release(collision.gameObject);
            SFX.PlayGoodAudio();
            dogControl.SetBool("IsMad", false);
            dogControl.SetBool("IsHappy", true);
        }
        else if (collision.gameObject.CompareTag("Bad Food"))
        {
            gameManager.UpdateBadScore();
            spawner.badPool.Release(collision.gameObject);
            SFX.PlayBadAudio();
            dogControl.SetBool("IsHappy", false);
            dogControl.SetBool("IsMad", true);
        }
        else
        {
            Debug.Log("Game object doesn't have Tag");
        }
    }

    public void ChangeAnim()
    {
        if (dogControl.GetBool("IsHappy") == true)
        {
            dogControl.SetBool("IsHappy", false);
        }
        else if(dogControl.GetBool("IsMad") == true)
        {
            dogControl.SetBool("IsMad", false);
        }
    }
}
