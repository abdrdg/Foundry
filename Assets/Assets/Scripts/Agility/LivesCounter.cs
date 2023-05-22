using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesCounter : MonoBehaviour
{
    TextMeshProUGUI lives;
    public int livesCount = 3;
    // Start is called before the first frame update
    void Start()
    {
        lives = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "Lives: " + livesCount.ToString();
    }
}
