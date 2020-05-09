using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject desEffect;

    public bool destroyAfterDamaged = true;
    public bool destroyViaCollision = true;

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
        Stats enemy = hitInfo.GetComponent<Stats>();
        if(enemy != null)
        {
            enemy.TakeDamage(damagePoints);
        }
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        if(destroyAfterDamaged == true)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(destroyViaCollision == true)
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
