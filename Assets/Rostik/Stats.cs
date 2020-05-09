using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public GameObject VictoryScreen;
    public GameObject LoseScreen;


    public int HP = 100;
    public GameObject deathAnim;

    public void TakeDamage(int damage) 
    {
        HP -= damage;

        if(HP <= 0)
        {
            Die();
             
        }
    }

    void Die()
    {
        if (this.name == "Enemy")
        {

            VictoryScreen.SetActive(true);


        }
        else
        {
            LoseScreen.SetActive(true);

        }
        
        
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);


    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayPressed()
    {
        SceneManager.LoadScene("Robroy");
    }

}
