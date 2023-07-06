using UnityEngine;
using TMPro;

public class CollideWithObstacle : MonoBehaviour
{
    public GameObject _gameOverUI;
    public GameObject _playAgainButton;
    public GameObject _liveCounter;
    public GameObject _pauseButton;
    public AgilityMiniGameManager _gm;
    public AudioSource _bgm;
    public float invulnerableTimer;
    private float invulnerableTimerCur;
    private int counter;
    private bool recentlyDamaged = false;
    private float blinkInterval = 0.5f;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        _gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<AgilityMiniGameManager>();
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

    }
    private void Update()
    {
        if (invulnerableTimerCur <= 0)
        {
            recentlyDamaged = false;
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            invulnerableTimerCur -= 1 * Time.deltaTime;
            BlinkSprite();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (recentlyDamaged) return;

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //counter = _liveCounter.GetComponent<LivesCounter>().livesCount;
            //counter--;
            //_liveCounter.GetComponent<LivesCounter>().livesCount = counter;

            _gm.TakeDamage();
            recentlyDamaged = true;
            invulnerableTimerCur = invulnerableTimer;
            _gm._curLives -= 1;

            if (_gm._curLives < 1)
            {
                Destroy(this.gameObject);
                _bgm.Stop();
                _gameOverUI.SetActive(true);
                _playAgainButton.SetActive(true);
                _pauseButton.SetActive(false);
                Time.timeScale = 0.0f;
            }
        }
    }
    private void BlinkSprite()
    {
        float remainder = invulnerableTimerCur % blinkInterval;

        if (remainder < blinkInterval / 2)
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            spriteRenderer.color = new Color(1f, 1f, 1f, 0.5f);
        }
    }
}
