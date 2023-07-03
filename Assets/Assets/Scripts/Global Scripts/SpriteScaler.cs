using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScaler : MonoBehaviour
{
    public float targetWidth = 1080f; // The width of the screen you designed the sprites for

    private void Start()
    {
        ScaleSprites();
        ScaleColliders();
    }
    private void ScaleSprites()
    {
        SpriteRenderer[] spriteRenderers = FindObjectsOfType<SpriteRenderer>();

        float currentScreenWidth = Screen.width;
        float scaleFactor = currentScreenWidth / targetWidth;

        foreach (SpriteRenderer spriteRenderer in spriteRenderers)
        {
            spriteRenderer.transform.localScale = new Vector3(scaleFactor, scaleFactor, 1f);
        }
    }

    private void ScaleColliders()
    {
        Collider2D[] colliders = FindObjectsOfType<Collider2D>();

        foreach (Collider2D collider in colliders)
        {
            // Scale the collider's size
            collider.transform.localScale *= collider.transform.localScale.x;
        }
    }
}