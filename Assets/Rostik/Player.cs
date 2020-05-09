using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerHP = 100;
    public GameObject deathAnim;

    public void Damage(int dp) {
        playerHP -= dp;

        if(playerHP <= 0)
        {
            PlayerDie();
        }
    }

    void PlayerDie()
    {
        //Somewhat
    }
}
