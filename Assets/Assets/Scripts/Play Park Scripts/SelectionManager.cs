using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public GameObject _dogSelected;

    public void SelectGameObject(GameObject gameObject)
    {
        _dogSelected = gameObject;
    }

    public void ClearSelectedDog()
    {
        _dogSelected = null;
    }

    public void ToggleSelectedGameObject()
    {
        if (_dogSelected != null)
         _dogSelected.SetActive(!_dogSelected.activeSelf);
        }

}