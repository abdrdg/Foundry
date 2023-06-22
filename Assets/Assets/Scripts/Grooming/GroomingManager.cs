using UnityEngine;
using UnityEngine.Animations;
using System.Collections;

public class GroomingManager : MonoBehaviour
{
    public GameObject Soap;
    public GameObject Shower;
    public GameObject Dryer;
    public GameObject Brush;
    public GameObject curtain;
    public GameObject Shower2;

    public Canvas _menuUI;

    public int stage = 1;

    private void Start()
    {
        EquipShower();
    }

    private void Update()
    {
        if(stage > 5) { 
            _menuUI.gameObject.SetActive(true);
        }
    }

    protected GameObject OnMouse;
    public void EquipSoap()
    {
        AntiStack();
        OnMouse = Instantiate(Soap, transform.position, Quaternion.identity);
    }
    public void EquipShower()
    {
        AntiStack();
        OnMouse = Instantiate(Shower, transform.position, Quaternion.identity);
    }
    public void EquipDryer()
    {
        AntiStack();
        OnMouse = Instantiate(Dryer, transform.position, Quaternion.identity);
    }
    public void EquipBrush()
    {
        AntiStack();
        OnMouse = Instantiate(Brush, transform.position, Quaternion.identity);
    }

    public void EquipShower2()
    {
        AntiStack();
        OnMouse = Instantiate(Shower2, transform.position, Quaternion.identity);
    }

    private void AntiStack()
    {
        if (OnMouse != null)
        {
            Destroy(OnMouse);
        }
    }

    public void NextTool()
    {
        curtain.GetComponent<Animator>().SetBool("IsToolDone", true);
        curtain.GetComponent<Animator>().SetBool("IsIdle", false);
        StartCoroutine(delay());
        stage += 1;
        switch (stage)
        {
            case 5:
                EquipBrush();
                break;
            case 4:
                EquipDryer();
                break;
            case 3:
                EquipShower2();
                break;
            case 2:
                EquipSoap();
                break;
            case 1:
                EquipShower();
                break;
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
    IEnumerator delay()
    {
       
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        curtain.GetComponent<Animator>().SetBool("IsToolDone", false);
        curtain.GetComponent<Animator>().SetBool("IsIdle", true);
    }

}

