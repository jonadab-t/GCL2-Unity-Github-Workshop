using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class EnemySlow : MonoBehaviour
{
    public float moveSpeed;
    //public Transform leftPoint;
    //public Transform rightPoint;
    
    public bool movingLeft = true;
    private Rigidbody2D enemyRigidbody;
    protected Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = movingLeft ? 1f : -1f;
        rb.linearVelocity = new Vector2(direction * moveSpeed, rb.linearVelocity.y);
    }
}
