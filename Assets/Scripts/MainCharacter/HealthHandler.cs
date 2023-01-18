using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    [SerializeField] private int currentHealth = 100;

    [SerializeField] private HealthBarHandler healthBarHandler;

    private void Start()
    {
        healthBarHandler.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBarHandler.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeHeal(int heal)
    {
        currentHealth += heal;
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            healthBarHandler.SetHealth(currentHealth);
        }
        else
        {
            healthBarHandler.SetHealth(currentHealth); 
        }
            
    }

}
