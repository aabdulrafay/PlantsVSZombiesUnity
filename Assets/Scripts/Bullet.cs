using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    public int damage = 10;
    public int row;

    public GameObject hitEffect; // drag explosion prefab here

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // shoot bullet to right side
        rb.AddForce(Vector2.right * bulletSpeed, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Debug.Log("Bullet hit zombie");

            ZombieHealth zh = collision.gameObject.GetComponent<ZombieHealth>();

            if (zh != null)
            {
                zh.TakeDamage(damage);
            }

            // create explosion effect
            if (hitEffect != null)
            {
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect, 0.3f);
            }

            // destroy bullet
            Destroy(gameObject);
        }
    }
}