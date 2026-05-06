using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        PlayerController Player = GetComponent<PlayerController>();
        if (Player)
            print("Player Landed on Spike");

     }
    // Update is called once per frame
    void Update()
    {
        
    }
}
