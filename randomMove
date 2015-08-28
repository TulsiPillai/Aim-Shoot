using UnityEngine;
using System.Collections;

public class randomMove : MonoBehaviour {
	private float nextActionTime  = 10.0f;
	private float timeInterval = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit();
		}
		if (Time.time > nextActionTime) {
			Vector3 position = new Vector3 ((Random.Range (-30.0f, 30.0f)), 0, (Random.Range (-30.0f, 30.0f)));
			gameObject.transform.position = position;
			nextActionTime += timeInterval;
		}
	}
}
