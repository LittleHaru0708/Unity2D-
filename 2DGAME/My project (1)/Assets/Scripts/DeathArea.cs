using UnityEngine;

public class DeathArea : MonoBehaviour
{
    private async void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DeathCounter.Instance.AddDeath();

            await RespawnManager.Instance
                .RespawnPlayer(other.gameObject);
        }
    }
}