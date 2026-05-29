
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class DeadZone : MonoBehaviour
{
    private async void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            await DeadAsync();
        }
    }

    private async UniTask DeadAsync()
    {
        Debug.Log("DEAD");

        await UniTask.Delay(1000);

        await SceneManager.LoadSceneAsync("GameScene");
    }
}
