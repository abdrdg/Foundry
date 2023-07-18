using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDogSO : MonoBehaviour
{
    public GameObject Dog;
    private DogSelectorSingleton dss;

    private void Awake()
    {
        dss = DogSelectorSingleton.Instance;
    }

    private void Start()
    {
        if(dss != null && Dog != null ) {
            Dog.GetComponent<GetDogSO>().dogData = dss.dogSO;
            Dog.GetComponent<GetDogSO>()._fileName = dss.dogSO._fileName;
            Dog.GetComponent<GetDogSO>().SetDataOnStart();
            Dog.GetComponent<GetDogSO>().LoadSavedDogData();
            Dog.GetComponent<GetDogSO>().ApplyStatsInData();
            dss.DestroyThyself();
        }
        
    }
}
