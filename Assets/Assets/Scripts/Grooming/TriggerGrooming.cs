using UnityEngine;

public class TriggerGrooming : MonoBehaviour
{
    public GameObject dog;

    public float _soapingProgression = 0;
    private float _maxSoapingProgression = 100;
    public float _soapSpeed;

    public void Update()
    {
        if(_soapingProgression > 0 && _soapingProgression != _maxSoapingProgression )
        {
            _soapingProgression -= 1 * Time.deltaTime;
        }

        if(_soapingProgression == _maxSoapingProgression )
        {
            Debug.Log("Finish Soaping");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            dog = collision.gameObject;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (dog != null)
            {
                _soapingProgression += _soapSpeed * Time.deltaTime;

                if(_soapingProgression >= _maxSoapingProgression)
                {
                    _soapingProgression = _maxSoapingProgression;
                }
            }
        }
    }
}
