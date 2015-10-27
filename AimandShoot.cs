using UnityEngine;
using System.Collections;

public class AimAndShoot : MonoBehaviour {
	public Transform direction; 
	public GameObject bullet;
	public float intensity;
	public float offset;
	private float timeLeft=10;
	private GameObject gameController;
	//public Transform gunFront;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Fire1")) {
			GameObject current = Instantiate(bullet, direction.position, Quaternion.identity) as GameObject;
			current.GetComponent<Rigidbody>().AddForce (direction.forward * intensity);
		}
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			print(" Time up");
		}
	}
}
