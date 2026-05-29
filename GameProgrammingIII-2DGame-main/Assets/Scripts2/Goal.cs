
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class Goal : MonoBehaviour
{
    private async void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            await ClearAsync();
        }
    }

    private async UniTask ClearAsync()
    {
        Debug.Log("CLEAR");

        await UniTask.Delay(1500);

        await SceneManager.LoadSceneAsync("ClearScene");
    }
}
