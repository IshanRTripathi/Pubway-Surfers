using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeScreen : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
            //Debug.Log("QuitButtonPressed");
        }
    }
    public void StartLevelGame()
    {
        //FindObjectOfType<DisableAfterTime>().isLevelGame = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void StartInfiniteGame()
    {
        //FindObjectOfType<DisableAfterTime>().isLevelGame = false;
        SceneManager.LoadScene("Level4");
    }
}
