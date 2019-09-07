using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterTime : MonoBehaviour {
	public float lifeTime = 8f;
    public bool isLevelGame = true;
    // Use this for initialization
    void OnEnable () {
        if(isLevelGame==true)
		StartCoroutine(Disabler());
	}
	private IEnumerator Disabler()
	{
		yield return new WaitForSeconds(lifeTime);
		gameObject.SetActive(false);
	}

}
