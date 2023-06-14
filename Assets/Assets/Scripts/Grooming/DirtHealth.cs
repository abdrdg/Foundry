using UnityEngine;

public class DirtHealth : MonoBehaviour
{
    public float _hp;
    public DirtHolder dh;

    private void Update()
    {
        if(_hp <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        dh.Dirt.Remove(this.gameObject);
        Destroy(this.gameObject);
    }
}
