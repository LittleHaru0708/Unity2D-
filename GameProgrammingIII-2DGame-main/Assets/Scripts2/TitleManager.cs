
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class TitleManager : MonoBehaviour
{
    public async void StartGame()
    {
        await UniTask.Delay(500);

        await SceneManager.LoadSceneAsync("GameScene");
    }
}
