using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DirtHolder : MonoBehaviour
{
    public List<GameObject> Dirt = new List<GameObject>();
    public SpriteRenderer spriteRenderer;
    public Sprite WetSprite;
    public EndOfShowering eos;


    public void Update()
    {
        if(this.Dirt.Count == 0)
        {
            ChangeSprite();
        }

    }

    public void ChangeSprite()
    {
        spriteRenderer.sprite = WetSprite;
    }

}
