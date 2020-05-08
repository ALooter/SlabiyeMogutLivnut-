using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject desEffect;

    public float bulletDestroyTime = 1; 
    public int damagePoints = 10;

    void Update()
    {
        //GameObject effect = Instantiate(desEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject, bulletDestroyTime);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damagePoints);
        }
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
