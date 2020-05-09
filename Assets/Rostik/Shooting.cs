using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //public Animator animator;

    public int weapon = 0;

    public Transform shootpoint;
    public GameObject bulletPrefab;
     public float bulletForce = 20f;

    public Transform swordPoint;
    public float swordRange = 0.5f;
    public LayerMask enemyLayers;
    public int swordDM = 10;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(weapon == 0)
                Shoot();
            else if(weapon == 1)
                Hit();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootpoint.position, shootpoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootpoint.up * bulletForce, ForceMode2D.Impulse);
    }

    void Hit() 
    {
        //animator.SetTrigger("SwordAttack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(swordPoint.position, swordRange, enemyLayers);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Stats>().TakeDamage(swordDM);
        }
    }

    void OnDrawGizmosSelected() {
        if(swordPoint == null)
            return;

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(swordPoint.position, swordRange);
    }
}
