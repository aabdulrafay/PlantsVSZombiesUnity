using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // move left toward plants
        rb.AddForce(Vector2.left * speed, ForceMode2D.Force);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            //print in console
            Debug.Log("Zombie collided with a plant!");
            // stop moving when colliding with a plant
            rb.velocity = Vector2.zero;
        }
    }
}