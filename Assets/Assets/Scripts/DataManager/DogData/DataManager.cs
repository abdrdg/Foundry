using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public DogData _dogData; // Reference to the DogData object to be saved

    private void OnApplicationQuit()
    {
        Save(_dogData, "SaveData.dat");
    }

    public void Save(DogData data, string fileName)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Path.Combine(Application.persistentDataPath, fileName);

        try
        {
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, data);
            }
            Debug.Log("Save successful: " + path);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error saving file: " + e.Message);
        }
    }

    public DogData Load(string fileName)
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    DogData data = formatter.Deserialize(stream) as DogData;
                    return data;
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error loading file: " + e.Message);
                return null;
            }
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
