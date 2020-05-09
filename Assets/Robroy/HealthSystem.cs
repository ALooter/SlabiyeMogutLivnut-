using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthSystem : MonoBehaviour
{
    public int health;
    public int numberofLifes;
    public Image[] lives;

    public Sprite fullLive;
    public Sprite EmptyLife;

    void Update()

    {
        if (health > numberofLifes)
        {
            health = numberofLifes;
        }

        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullLive;

            }
            else
            {
                lives[i].sprite = EmptyLife;
            }




            if (i < numberofLifes)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }

        }





    }
}
 