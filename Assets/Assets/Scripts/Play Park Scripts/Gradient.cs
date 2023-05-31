using UnityEngine;
using UnityEngine.UI;

public class Gradient : MonoBehaviour
{
    public GameObject Fill;
    private Image img;
    public Color _color1;
    public Color _color2;

    public Vector4 color;
    
    // Start is called before the first frame update
    void Start()
    {
        img = Fill.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.GetComponent<Slider>().value > 50)
        {
            img.color = _color1;
        }    
        if(this.gameObject.GetComponent<Slider>().value < 50)
        {
            img.color = _color2;
        }
    }
}
