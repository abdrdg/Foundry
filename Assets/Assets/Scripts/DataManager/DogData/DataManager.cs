// Add System.IO to work with files!
using System.IO;
// Add System.Runtime.Serialization.Formatters.Binary to work with BinaryFormatter!
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DataManager : MonoBehaviour
{
    public void Save(DogData data, string fileName)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + fileName;
        FileStream stream = new FileStream(path, FileMode.Create);

        formatter.Serialize(stream, data);

        Debug.Log(path);
        stream.Close();
    }

    public DogData Load(string fileName)
    {
        string path = Application.persistentDataPath + "/"+ fileName;

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            DogData data = formatter.Deserialize(stream) as DogData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
