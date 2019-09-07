using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBall : MonoBehaviour {
    public float spawnTime = 1f;

    [Header("The ball was already present in the object pooler")]
	public int ballIndex = 0;
	[Header("This ball will be added to the object pooler when the game begins")]
	public GameObject differentBall;
	private int differentIndex;
	private ObjectPooler OP;
	public Transform SpawnPoint;
	private void Start()
	{
		OP = ObjectPooler.SharedInstance;
		differentIndex = OP.AddObject(differentBall);
		Random.InitState((int)System.DateTime.Now.Ticks);
	}
	// Update is called once per frame
	void Update () {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0 && SpawnPoint.transform.position.y>0)
        {
            GameObject ball = OP.GetPooledObject(ballIndex);
            //ball.transform.rotation = SpawnPoint.transform.rotation;
            float xPos = Random.Range(-4f, 4f);
            float zPos = Random.Range(-2f, 2f) + 50;
            ball.transform.position = SpawnPoint.transform.position + xPos * Vector3.right + zPos * Vector3.forward;
            ball.SetActive(true);
            spawnTime = 0.3f;
        }
		/*if (Input.GetKeyDown(KeyCode.LeftControl)|| Input.GetKeyDown(KeyCode.RightControl))
		{
			GameObject ball = OP.GetPooledObject(differentIndex);
			ball.transform.rotation = SpawnPoint.transform.rotation;
			float xPos = Random.Range(-5f, 5f);
			float zPos = Random.Range(-5f, 5f);
			ball.transform.position = SpawnPoint.transform.position + xPos * Vector3.right + zPos * Vector3.forward;
			ball.SetActive(true);
		}*/


	}
}
