using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScaler : MonoBehaviour
{
    public float targetWidth = 1080f; // The width of the screen you designed the sprites for
    private void Start()
    {
        ScaleSprites();
    }

    private void ScaleSprites()
    {
        SpriteRenderer[] spriteRenderers = FindObjectsOfType<SpriteRenderer>();

        foreach (SpriteRenderer spriteRenderer in spriteRenderers)
        {
            // Calculate the scaling factor based on the target width and the current screen width
            float scaleFactor = Screen.width / targetWidth;

            // Scale the sprite's size
            spriteRenderer.transform.localScale *= scaleFactor;
        }
    }
}
