using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forwardForce = 3500;
    public float forwardSpeed = 10f;
    public float sidewardForce = 150;
    public Rigidbody rigidbodyPlayer;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbodyPlayer.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x > Screen.width / 2)//Input.GetKey("d"))
                {
                    rigidbodyPlayer.AddForce(sidewardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
                    rigidbodyPlayer.AddForce(sidewardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
                    //rigidbody.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                }
                if (touch.position.x < Screen.width / 2)//Input.GetKey("a"))
                {
                    rigidbodyPlayer.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
                    rigidbodyPlayer.AddForce(-sidewardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
                    //rigidbody.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                }
            }
        }
        if (rigidbodyPlayer.position.y < -5f)
        {
            FindObjectOfType<GameController>().EndGame();
        }
    }
}
