using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy_AI : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movementEnemy;
    private EnemyAttack eattack;
    public int bb = 0;

    public float enemySpeed = 10;
    public float timerAttackBall = 10f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        eattack = this.GetComponent<EnemyAttack>();
    }

    void Update()
    {
        Vector2 dir = player.position - transform.position;

        eattack.AttackFlyingBall(rb.position.y, rb.position.x);
     

        dir.Normalize();
        movementEnemy = dir;
    }

    void FixedUpdate() 
    {
        rb.MovePosition((Vector2)transform.position + (movementEnemy * enemySpeed * Time.deltaTime));
    }
}
