using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private bool activated;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (activated)
            return;

        if (other.CompareTag("Player"))
        {
            activated = true;

            RespawnManager.Instance.SetCheckpoint(
                transform.position);
        }
    }
}