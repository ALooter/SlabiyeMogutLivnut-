using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int EnemyHP = 100;
    public GameObject deathEffect;

    public void TakeDamage(int damage) 
    {
        EnemyHP -= damage;

        if(EnemyHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
