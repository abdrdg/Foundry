using UnityEngine;
using TMPro;

public class CollideWithObstacle : MonoBehaviour
{
    public GameObject _gameOverUI;
    public GameObject _playAgainButton;
    public GameObject _liveCounter;
    public AudioSource _bgm;
    private int counter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            counter = _liveCounter.GetComponent<LivesCounter>().livesCount;
            counter--;
            _liveCounter.GetComponent<LivesCounter>().livesCount = counter;
            
            if(counter < 1)
            {
                Destroy(this.gameObject);
                _bgm.Stop();
                _gameOverUI.SetActive(true);
                _playAgainButton.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
}
