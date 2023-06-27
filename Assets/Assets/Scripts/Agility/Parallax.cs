using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform[] backgroundLayers; // Background layers to be parallaxed
    public float[] parallaxSpeeds; // Parallax speeds for each layer
    
    private void Start()
    {
        
    }

    private void Update()
    { 
        for (int i = 0; i < backgroundLayers.Length; i++)
        {
            float parallaxMovementX = -1 * parallaxSpeeds[i] * Time.deltaTime;

            Vector3 newPosition = backgroundLayers[i].position + new Vector3(parallaxMovementX, 0f, 0f);
            backgroundLayers[i].position = newPosition;
        }
    }


}
