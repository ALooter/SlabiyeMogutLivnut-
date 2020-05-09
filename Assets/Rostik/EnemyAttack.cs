using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform flyingBall;

    public bool ballPresent = false;

    public void AttackFlyingBall(float posY, float posX) {
        if(ballPresent == false) {
            GameObject ball = Instantiate(ballPrefab, flyingBall.position, flyingBall.rotation);  
            Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();   

            float angle = Mathf.Atan2(posY, posX) * Mathf.Rad2Deg;
            ballPresent = true;
        }

        
    }

    void Update() {

    }
}
