using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtHolder : MonoBehaviour
{
    public List<GameObject> Dirt = new List<GameObject>();
    public SpriteRenderer spriteRenderer;
    public Sprite WetSprite;
    public Sprite PoofySprite;

    public void Update()
    {
        if(Dirt.Count == 0)
        {
            ChangeSprite();
        }

    }

    public void ChangeSprite()
    {
       
            spriteRenderer.sprite = WetSprite;
    }
}
