using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class GetDogData : MonoBehaviour
{
    public DogData _dogData;
    public DogParent dp;
    public DataManager dataManager;

    //private bool isDataLoaded = false;
    public void Awake()
    {
       _dogData = dataManager.Load("Test Dog");
        //isDataLoaded = true;
       // dataManager.Save(this._dogData,this._dogData._dogName);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
