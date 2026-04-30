using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float speed = 0.5f;
    public int damage = 5;          // damage per hit
    public float attackRate = 1f;   // damage every 1 second

    private Rigidbody2D rb;
    private Animator animator;

    private bool isAttacking = false;
    private float attackTimer = 0f;

    private PlantHealth targetPlant;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (!isAttacking)
        {
            rb.velocity = new Vector2(-speed, 0f);
        }
        else
        {
            rb.velocity = Vector2.zero;

            // damage over time
            attackTimer += Time.deltaTime;

            if (attackTimer >= attackRate)
            {
                if (targetPlant != null)
                {
                    targetPlant.TakeDamage(damage);
                }

                attackTimer = 0f;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            Debug.Log("Zombie attacking!");

            isAttacking = true;
            animator.SetBool("isAttacking", true);

            targetPlant = collision.gameObject.GetComponent<PlantHealth>();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plant"))
        {
            isAttacking = false;
            animator.SetBool("isAttacking", false);

            targetPlant = null;
        }
    }
}