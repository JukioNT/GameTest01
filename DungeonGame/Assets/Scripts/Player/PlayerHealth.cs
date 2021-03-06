using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth;
    [HideInInspector]
    public int health;

    private Slider healthBar;

    private void Start()
    {
        healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<Slider>();
        healthBar.maxValue = maxHealth;
        health = maxHealth;
    }

    void Update()
    {
        healthBar.value = health;
    }

    public void GetLife(int life)
    {
        health = health + life;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
