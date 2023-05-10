using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlCollider : MonoBehaviour
{
    public FeedingGameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Good Food"))
        {
            gameManager.UpdateGoodScore();
            Destroy(collision.gameObject);          
        }
        else if (collision.gameObject.CompareTag("Bad Food"))
        {
            gameManager.UpdateBadScore();
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("Game object doesn't have Tag");
        }
    }
}