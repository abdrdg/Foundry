using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapingHP : MonoBehaviour
{
    public float _hp;
    public SpriteRenderer spriteRenderer;
    public Sprite SoapSprite;
    public Sprite _previousSprite;

    private void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        _previousSprite = spriteRenderer.sprite;
    }
    private void Update()
    {
      if(_hp >= 100)
        {
            _hp= 100;
        }

        if (_hp > 50 && SoapSprite != null)
        {
            ChangeSprite();
        }
    }

    public void ChangeSprite()
    {
        spriteRenderer.sprite = SoapSprite;
    }
}
