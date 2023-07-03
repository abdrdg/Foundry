using UnityEngine;

public class DogSelectorSingleton : MonoBehaviour
{
    private static DogSelectorSingleton instance;
    public SelectionManager SelectionManager;
    // Add your persistent data variables here
    public DogSO dogSO;
  

    // Getter for the instance
    public static DogSelectorSingleton Instance
    {
        get { return instance; }
    }

    private void Update()
    {
        if(SelectionManager._dogSelected != null)
        {
            dogSO = SelectionManager._dogSelected.GetComponent<GetDogSO>().dogData;
        }
    }
    private void Awake()
    {
        // Singleton pattern implementation
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
