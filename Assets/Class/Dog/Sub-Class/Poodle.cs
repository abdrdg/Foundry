using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poodle : DogParent
{
    private void Awake()
    {
        #region for saving data
        //SaveData();
        //dataManager.Save(this._dogData, this._dogData._dogName);
        #endregion


        #region for loading data
        //_dogData = dataManager.Load("John");
        //LoadData();
        #endregion

    }
}
