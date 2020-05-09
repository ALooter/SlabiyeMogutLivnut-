using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    public Transform weapon;
    private Vector2 movementEnemy;

    public float x = 0;
    public float y = 0;
    public float z = 0;

    public float enemySpeed = 10;
    public float timerAttackBall = 10f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 dir = player.position - transform.position;

        weapon.transform.localPosition = new Vector3 (x, y, z);

        dir.Normalize();
        movementEnemy = dir;
    }

    void FixedUpdate() 
    {
        rb.MovePosition((Vector2)transform.position + (movementEnemy * enemySpeed * Time.deltaTime));
    }
}
