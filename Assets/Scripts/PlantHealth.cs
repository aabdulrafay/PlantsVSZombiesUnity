using UnityEngine;
using TMPro;

public class PlantHealth : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI healthText;

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