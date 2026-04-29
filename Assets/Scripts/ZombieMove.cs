using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed = 0.5f;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isAttacking = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (isAttacking == false)
        {
            rb.velocity = new Vector2(-speed, 0f);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            Debug.Log("Zombie collided with a plant!");

            isAttacking = true;
            animator.SetBool("isAttacking", true);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            isAttacking = false;
            animator.SetBool("isAttacking", false);
        }
    }
}