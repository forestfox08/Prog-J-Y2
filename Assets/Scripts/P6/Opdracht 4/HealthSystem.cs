using System;
using UnityEngine;
using UnityEngine.UI;
public class HealthSystem : MonoBehaviour
{
    public int health = 100;

    public Action onHealthChanged;
    public Action onDeath;
    public void TakeDamage(int damage)
    {
        health -= damage;
        onHealthChanged?.Invoke();

        if (health <= 0)
        {
            onDeath?.Invoke();
        }
    }
}

public class HealthUI : MonoBehaviour
{
    public Text healthText;

    void Start()
    {
        HealthSystem hs = FindFirstObjectByType<HealthSystem>();
        hs.onHealthChanged += UpdateHealthUI;
        hs.onDeath += GameOver;
    }

    void UpdateHealthUI()
    {
        HealthSystem hs = FindFirstObjectByType<HealthSystem>();
        healthText.text = "Health: " + hs.health.ToString();
    }

    void GameOver() 
    { 
        Debug.Log("Game Over!");
    }
}