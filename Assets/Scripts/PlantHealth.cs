using UnityEngine;
using UnityEngine.UI;

public class PlantHealth : MonoBehaviour
{
    public int health = 100;
    public Text  healthText;

    void Start()
    {
        UpdateHealthText();
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;
        UpdateHealthText();

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void UpdateHealthText()
    {
        healthText.text = "Plant HP: " + health;
    }
}