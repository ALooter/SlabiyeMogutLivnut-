using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int HP = 100;
    public GameObject deathAnim;
    public healthbarscript hpscript;

   /* private void Start()
    {
        hpscript.SetMaxHealth(HP);
    }*/
    public void TakeDamage(int damage) 
    {
        HP -= damage;
        hpscript.SetHealth(HP);

        if(HP <= 0)
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
