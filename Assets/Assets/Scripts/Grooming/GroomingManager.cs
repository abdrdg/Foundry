using UnityEngine;
using UnityEngine.Animations;
using System.Collections;

public class GroomingManager : MonoBehaviour
{
    public GameObject Soap;
    public GameObject Shower;
    public GameObject Dryer;
    public GameObject Brush;
    public Animator curtain;
    public int stage = 1;

    private void Start()
    {
        EquipShower();
    }

    private void Update()
    {
        
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

    private void AntiStack()
    {
        if (OnMouse != null)
        {
            Destroy(OnMouse);
        }
    }

    public void NextTool()
    {
        curtain.SetBool("IsToolDone", true);
        curtain.GetBool("IsToolDone");
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
                EquipShower();
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
        curtain.SetBool("IsToolDone", false);
        curtain.GetBool("IsToolDone");
    }
    IEnumerator delay()
    {
       
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

    }

}

