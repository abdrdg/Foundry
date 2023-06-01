using System.ComponentModel.Design;
using UnityEngine;

public class TriggerGrooming : MonoBehaviour
{
    public GameObject dog;
    public GameObject previousSelected;

    public GroomingChecker gc;

    public float _soapingProgression = 0;
    public float _maxSoapingProgression = 100;
    public float _soapSpeed;

    public float _headProgressionStorer;
    public float _bodyProgressionStorer;
    public float _legProgressionStorer;
    public void Update()
    {
        if(dog!= null && dog.name != "Head" )
        {
            _bodyProgressionStorer -= 1 * Time.deltaTime;
            _legProgressionStorer -= 1 * Time.deltaTime;

            if (_bodyProgressionStorer < 0)
            {
                _bodyProgressionStorer = 0;
            }

            if(_legProgressionStorer < 0)
            {
                _legProgressionStorer = 0;
            }
        }
       
        if (dog != null && dog.name != "Body")
        {
            _headProgressionStorer -= 1 * Time.deltaTime;
            _legProgressionStorer -= 1 * Time.deltaTime;

            if (_headProgressionStorer < 0)
            {
                _headProgressionStorer = 0;
            }

            if(_legProgressionStorer < 0)
            {
                _legProgressionStorer = 0;
            }

        }
       
        if (dog != null && dog.name != "Legs")
        {
            _headProgressionStorer -= 1 * Time.deltaTime;
            _bodyProgressionStorer -= 1 * Time.deltaTime;

            if (_headProgressionStorer < 0)
            {
                _headProgressionStorer = 0;
            }

            if(_bodyProgressionStorer < 0)
            {
                _bodyProgressionStorer = 0;
            }
        }

        else if( dog == null )
        {
            _headProgressionStorer -= 1 * Time.deltaTime;
            _bodyProgressionStorer -= 1 * Time.deltaTime;
            _legProgressionStorer -= 1 * Time.deltaTime;

            if (_headProgressionStorer < 0)
            {
                _headProgressionStorer = 0;
            }

            if (_bodyProgressionStorer < 0)
            {
                _bodyProgressionStorer = 0;
            }

            if (_legProgressionStorer < 0)
            {
                _legProgressionStorer = 0;
            }
        }

        if (_soapingProgression == _maxSoapingProgression && gc != null )
        {
            if(this.gameObject.name == "Soap(Clone)")
            {
               gc.isFinishedSoaping = true;
            }

            if(this.gameObject.name == "Shower(Clone)")
            {
                gc.isFinishedShowering = true;
            }

            if(this.gameObject.name == "Brush(Clone)")
            {
                gc.isFinishedBrushing = true;
            }

            if(this.gameObject.name == "Dryer(Clone)")
            {
                gc.isFinishedDrying = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            dog = collision.gameObject;
            gc = dog.GetComponent<GroomingChecker>();
        }

        if (dog != null && previousSelected != null && previousSelected != dog)
        {
            if (dog.name == "Head")
            {
                _soapingProgression = _headProgressionStorer;
            }

            if (dog.name == "Body")
            {
                _soapingProgression = _bodyProgressionStorer;
            }

            if (dog.name == "Legs")
            {
                _soapingProgression = _legProgressionStorer;
            }
        }

        if (gc != null)
        {
            if (this.gameObject.name == "Soap(Clone)" && gc.isFinishedSoaping)
            {
                dog = null;
                previousSelected = null;
            }

            if(this.gameObject.name == "Shower(Clone)" && gc.isFinishedShowering)
            {
                dog = null;
                previousSelected = null;
            }

            if (this.gameObject.name == "Brush(Clone)" && gc.isFinishedBrushing)
            {
                dog = null;
                previousSelected = null;
            }

            if(this.gameObject.name == "Dryer(Clone)" && gc.isFinishedDrying)
            {
                dog = null;
                previousSelected = null;
            }    
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    { 
        if (dog != null)
        {
            _soapingProgression += _soapSpeed * Time.deltaTime;

            if (_soapingProgression >= _maxSoapingProgression)
            {
                _soapingProgression = _maxSoapingProgression;
                _soapingProgression = 100;

            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(dog != null)
        previousSelected = dog;
       

        if(previousSelected.name == "Head" && previousSelected != null)
        {
            _headProgressionStorer = _soapingProgression;
        }

        else if (previousSelected.name == "Body" && previousSelected != null)
        {
            _bodyProgressionStorer = _soapingProgression;
        }

        else if (previousSelected.name == "Legs" && previousSelected != null)
        {
            _legProgressionStorer = _soapingProgression;
        }
    }
}
