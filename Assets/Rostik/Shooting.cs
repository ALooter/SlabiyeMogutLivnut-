﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Animator animator;
    public AudioManager am;

    public int weapon = 0;

    public Transform shootpoint;
    public GameObject bulletPrefab;
     public float bulletForce = 20f;

    public Transform swordPoint;
    public float swordRange = 0.5f;
    public LayerMask enemyLayers;
    public int swordDM = 10;

    public Animator animat;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            animat.SetBool("isRanged", true);
        }
        if (Input.GetButtonDown("Fire2")) 
        { 
            Hit();
            animat.SetBool("isRanged", false);
        }
    }


    void Shoot()
    {
        animat.SetBool("isAttacking", true);

        GameObject bullet = Instantiate(bulletPrefab, shootpoint.position, shootpoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootpoint.up * bulletForce, ForceMode2D.Impulse);

        am.Play("bullet");
    }

    void Hit() 
    {
       animat.SetBool("isAttacking", true);

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(swordPoint.position, swordRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Stats>().TakeDamage(swordDM);
        }

        am.Play("sword");
    }

    void OnDrawGizmosSelected() {
        if(swordPoint == null)
            return;

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(swordPoint.position, swordRange);
    }
}
