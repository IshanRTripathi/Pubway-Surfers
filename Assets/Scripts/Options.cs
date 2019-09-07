using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject optionsButton;

    void Start()
    {
        optionsButton = GameObject.Find("OptionsButton");
    }

    public void ControllOptionsButton()
    {
        if (PlayPause.isPaused == true)
        {
            optionsButton.SetActive(true);
            //Debug.Log("Active");
        }
        else
        {
            optionsButton.SetActive(false);
            //Debug.Log("Not Active");
        }
    }
}
