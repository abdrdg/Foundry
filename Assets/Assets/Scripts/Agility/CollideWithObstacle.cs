using UnityEngine;
using TMPro;

public class CollideWithObstacle : MonoBehaviour
{
    public GameObject _gameOverUI;
    public GameObject _playAgainButton;
    public GameObject _liveCounter;
    public AgilityMiniGameManager _gm;
    public AudioSource _bgm;
    private int counter;

    private void Start()
    {
        _gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<AgilityMiniGameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //counter = _liveCounter.GetComponent<LivesCounter>().livesCount;
            //counter--;
            //_liveCounter.GetComponent<LivesCounter>().livesCount = counter;

            _gm.TakeDamage();
            _gm._curLives -= 1;
            
            if(_gm._curLives < 1)
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
