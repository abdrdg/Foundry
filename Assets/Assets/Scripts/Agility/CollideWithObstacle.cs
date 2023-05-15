using UnityEngine;
using TMPro;

public class CollideWithObstacle : MonoBehaviour
{
    public GameObject _gameOverUI;
    public GameObject _playAgainButton;
    public GameObject _liveCounter;
    private int counter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //livesCount--;
            counter = _liveCounter.GetComponent<LivesCounter>().livesCount;
            counter--;
            _liveCounter.GetComponent<LivesCounter>().livesCount = counter;
            
            if(counter < 1)
            {
                Destroy(this.gameObject);

                _gameOverUI.SetActive(true);
                _playAgainButton.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
}
