using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;

    private SaveData saveData;

    private void Awake()
    {
        Instance = this;

        Load();
    }

    public void Save()
    {
        string json =
            JsonUtility.ToJson(saveData);

        PlayerPrefs.SetString(
            "SAVE",
            json);
    }

    public void Load()
    {
        if (!PlayerPrefs.HasKey("SAVE"))
        {
            saveData = new SaveData();
            return;
        }

        string json =
            PlayerPrefs.GetString("SAVE");

        saveData =
            JsonUtility.FromJson<SaveData>(json);
    }

    public SaveData GetData()
    {
        return saveData;
    }
}