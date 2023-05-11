using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI timer;
    public float showntime = 30, time; 
    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.GetComponent<TextMeshProUGUI>();
        timer.text = showntime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime;
        showntime -= time;
        timer.text = Mathf.Round(showntime).ToString();
        if (Mathf.Sign(showntime) == -1)
        {
            timer.text = "Done";
        }
    }
}
