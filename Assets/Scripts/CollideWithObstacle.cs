using UnityEngine;
using TMPro;

public class CollideWithObstacle : MonoBehaviour
{
    public GameObject _gameOverUI;
    public GameObject _playAgainButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);

            _gameOverUI.SetActive(true);
            _playAgainButton.SetActive(true);
        }
    }
}
