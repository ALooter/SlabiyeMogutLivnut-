using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{

    public void PlayPressed()
    {
        SceneManager.LoadScene("Robroy");
    }

    public void ScorePressed()
    {
            
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
