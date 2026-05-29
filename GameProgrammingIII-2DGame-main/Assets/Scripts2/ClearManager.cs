
using UnityEngine;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class ClearManager : MonoBehaviour
{
    public async void BackTitle()
    {
        await UniTask.Delay(500);

        await SceneManager.LoadSceneAsync("TitleScene");
    }
}
