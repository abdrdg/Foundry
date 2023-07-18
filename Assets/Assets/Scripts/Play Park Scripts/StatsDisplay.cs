using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsDisplay : MonoBehaviour
{
    public GetDogSO gds;
    public SelectionManager _sm;

    public TextMeshProUGUI dogtypeTMP_Text;
    public TextMeshProUGUI dognameTMP_Text;
    public TextMeshProUGUI agilityTMP_Text;
    public TextMeshProUGUI beautyTMP_Text;
    public TextMeshProUGUI obedienceTMP_Text;

    public Image artworkImage;
                            
    void Start()
    {
      
        //artworkImage.sprite = dog._image;
    }

    private void Update()
    {
       if(_sm._dogSelected != null)
        {
            gds = _sm._dogSelected.GetComponent<GetDogSO>();

            dogtypeTMP_Text.text = gds._dogType;
            dognameTMP_Text.text = gds._dogName;
            agilityTMP_Text.text = "Agility: " + gds._agility.ToString();
            beautyTMP_Text.text = "Beauty: " + gds._beauty.ToString();
            obedienceTMP_Text.text = "Obedience: " + gds._obedience.ToString();
        }
    }
}
