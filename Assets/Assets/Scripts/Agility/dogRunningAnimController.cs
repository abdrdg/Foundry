using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogRunningAnimController : MonoBehaviour
{
    public Animator anim;
    public int RandomNumber;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            RandomNumber = Random.Range(1, 5);
            PlayAnim(RandomNumber);
      
    }

    void PlayAnim(int numberRef)
    {
        anim.SetInteger("AnimInt", numberRef);
    }



}
