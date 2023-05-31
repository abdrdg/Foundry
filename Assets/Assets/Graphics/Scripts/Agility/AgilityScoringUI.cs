using UnityEngine;
using TMPro;

public class AgilityScoringUI : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    public int _scoreCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + _scoreCount.ToString();
    }
}
