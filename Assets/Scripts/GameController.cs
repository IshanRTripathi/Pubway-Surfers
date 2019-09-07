using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    bool gameEnded = false;
    public float restartTimer = 3f;

    public GameObject levelCompleteUI;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(0);
            //Debug.Log("BackButtonPressed");
        }
    }
    public void EndGame()
    {
        SoundManager.instance.musicSource.Stop();
        if (gameEnded == false)
        {
            gameEnded = true;
            // Debug.Log("End!!");
            Invoke("Restart", restartTimer);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
        //Debug.Log("Completed!!");
    }
}
