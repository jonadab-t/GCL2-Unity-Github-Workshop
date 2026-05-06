using UnityEngine;

public class ShawnSpike : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("GG. Hit spikes.");
            // add other logic here, such as reducing player health or restarting the level
        }
    }
}
