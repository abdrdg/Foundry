using UnityEngine;
using UnityEngine.UI;

public class SliderGradient : MonoBehaviour
{
    public Slider slider;
    public Image fillImage;
    public Sprite fillSprite;
    public Color minColor;
    public Color maxColor;

    private void Start()
    {
        fillImage.sprite = fillSprite;
        UpdateSliderColor();
    }

    public void UpdateSliderColor()
    {
        float normalizedValue = (slider.value - slider.minValue) / (slider.maxValue - slider.minValue);
        fillImage.fillAmount = normalizedValue;
        fillImage.color = Color.Lerp(minColor, maxColor, normalizedValue);
    }
}
