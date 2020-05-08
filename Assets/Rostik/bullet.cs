using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject desEffect;
    public float bulletDestroyTime = 60; 
    

    void Update()
    {
        //GameObject effect = Instantiate(desEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject, bulletDestroyTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
