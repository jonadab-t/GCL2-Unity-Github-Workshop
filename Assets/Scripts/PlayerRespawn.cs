using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 currentCheckpoint;

    void Start()
    {
        currentCheckpoint = transform.position; // default spawn
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        currentCheckpoint = newCheckpoint;
        Debug.Log("Checkpoint updated: " + newCheckpoint);
    }

    public void Respawn()
    {
        transform.position = currentCheckpoint;
    }
}
