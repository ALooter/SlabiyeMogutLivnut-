using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShooting : MonoBehaviour
{   
    public Transform shootpoint;
    public Rigidbody2D targetPoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    public Transform swordPoint;
    public float swordRange = 0.5f;
    public LayerMask enemyLayers;
    public int swordDM = 10;

    public Transform player;

    public int varAttack = 0;

    void Update() {

        Vector3 dir = player.position - transform.position;
        float angl = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        targetPoint.rotation = angl;

        if(varAttack == 0){
            Shoot();
        }
        else if(varAttack == 1) {
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
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(swordPoint.position, swordRange, enemyLayers);
        foreach (Collider2D player in hitEnemies)
        {
            player.GetComponent<Stats>().TakeDamage(swordDM);
        }
    }

    void OnDrawGizmosSelected() {
        if(swordPoint == null)
            return;

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(swordPoint.position, swordRange);
    }

}
