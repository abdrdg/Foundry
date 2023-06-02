using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsDisplay : MonoBehaviour
{
    public DogSO dog;

    public TextMeshProUGUI dogtypeTMP_Text;
    public TextMeshProUGUI dognameTMP_Text;
    public TextMeshProUGUI agilityTMP_Text;
    public TextMeshProUGUI beautyTMP_Text;
    public TextMeshProUGUI obedienceTMP_Text;

    public Image artworkImage;

    void Start()
    {
        dogtypeTMP_Text.text = dog._dogType; 
        dognameTMP_Text.text = dog._dogName; 
        agilityTMP_Text.text = "Agility: " + dog._agility.ToString(); 
        beautyTMP_Text.text = "Beauty: " + dog._beauty.ToString(); 
        obedienceTMP_Text.text = "Obedience: " + dog._obedience.ToString(); 

        artworkImage.sprite = dog._image;
    }
}
