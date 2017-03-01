using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(RemoveAfterSeconds(10));
	}

	IEnumerator RemoveAfterSeconds(int seconds)
	{
		yield return new WaitForSeconds(seconds);
		gameObject.SetActive(false);
	}
}
