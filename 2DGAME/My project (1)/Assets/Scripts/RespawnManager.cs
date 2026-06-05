using Unity.VisualScripting;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class RespawnManager : MonoBehaviour
{
    public static RespawnManager Instance;

    private Vector3 currentCheckpoint;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentCheckpoint = GameObject
            .FindGameObjectWithTag("Player")
            .transform.position;
    }

    public void SetCheckpoint(Vector3 pos)
    {
        currentCheckpoint = pos;
    }

    public async UniTask RespawnPlayer(GameObject player)
    {
        player.SetActive(false);

        await UniTask.Delay(500);

        player.transform.position = currentCheckpoint;

        player.SetActive(true);
    }
}