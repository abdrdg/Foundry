using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassToDataManager : MonoBehaviour
{
    public GetDogSO gds;
    public DataManager dtm;

    void Save()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
           dtm.Save(gds.dogData,"DogSample");
        }
    }
}
