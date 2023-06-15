using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxChecker : MonoBehaviour
{
    public GameObject parallaxHolder;
    public GameObject BG;
    public GameObject toInstantiate;

    private void Start()
    {

    }
    private void Update()
    {
       if(BG == null)
       {
            BG = Instantiate(toInstantiate, parallaxHolder.transform.position, Quaternion.identity);
       }

       if(BG != null)
        {
            if(BG.transform.position.x <= 0)
                { BG = null; }
           
        }
        
    
    }

}
