using System;
using UnityEngine;
using WeaponSystem;
using WeaponSystem.Interfaces;

public class EnemyHealth: MonoBehaviour, IDamageable
{
    private float health;
    private int damage;
    public ScriptableObjects.EnemyHealth PrefabHealth;

   

    private void Awake()
    {
        health = PrefabHealth.prefabHealth;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Health "  + health  +   " damage "  + damageAmount);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}