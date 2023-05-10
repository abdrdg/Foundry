using TMPro;
using UnityEngine;

public class AgilityScoring : MonoBehaviour
{
    public GameObject ScoreUI;
  
    public int scoreToGive = 100;
    // Start is called before the first frame update

    private void Awake()
    {
        ScoreUI = GameObject.FindGameObjectWithTag("ScoreUI");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           AgilityScoringUI absUI = ScoreUI.GetComponent<AgilityScoringUI>();
            absUI._scoreCount += 100;
        }
    }
}
