using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text timerText;

    private float currentTime;

    private void Update()
    {
        currentTime += Time.deltaTime;

        timerText.text =
            currentTime.ToString("F2");
    }

    public float GetTime()
    {
        return currentTime;
    }
}