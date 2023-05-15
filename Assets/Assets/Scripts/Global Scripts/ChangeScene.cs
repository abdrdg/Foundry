using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToScene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}