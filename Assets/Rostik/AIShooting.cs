using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShooting : MonoBehaviour
{   
    public Transform shootpoint;
    public Rigidbody2D targetPoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public Transform player;

    void Update() {

        Vector3 dir = player.position - transform.position;
        float angl = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
        targetPoint.rotation = angl;

        Shoot();
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootpoint.position, shootpoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(shootpoint.up * bulletForce, ForceMode2D.Impulse);
    }

}
