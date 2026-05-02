using UnityEngine;
using UnityEngine.UI;

public class ZombieHealth : MonoBehaviour
{
    public int health = 100;

    public Text healthText; // assign in Inspector

    void Start()
    {
        UpdateHealthText();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        UpdateHealthText();

        if (health <= 0)
        {
            Die();
        }
    }

    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Zombie HP: " + health;
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}