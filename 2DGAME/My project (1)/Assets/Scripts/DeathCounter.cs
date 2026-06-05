using TMPro;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    public static DeathCounter Instance;

    [SerializeField]
    private TMP_Text deathText;

    private int deathCount;

    private void Awake()
    {
        Instance = this;
    }

    public void AddDeath()
    {
        deathCount++;

        deathText.text =
            $"Deaths : {deathCount}";
    }

    public int GetDeathCount()
    {
        return deathCount;
    }
}