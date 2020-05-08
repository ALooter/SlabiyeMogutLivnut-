using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_AI : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    public Vector2 movementEnemy;

    public float enemySpeed = 10;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        dir.Normalize();
        movementEnemy = dir;
    }

    void FixedUpdate() 
    {
        rb.MovePosition((Vector2)transform.position + (movementEnemy * enemySpeed * Time.deltaTime));
    }
}
