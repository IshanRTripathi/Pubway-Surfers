using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameController controller;

    public void OnTriggerEnter(Collider other) {
        controller.CompleteLevel();
    }
}
