using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ThroughHoop : MonoBehaviour {
	private int counter = 0;
	private int anim1 = Animator.StringToHash("youwin");
	private Animator animator1;
	// Use this for initialization
	void Start () {
		animator1 = GameObject.Find ("youWin").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		print ("inside collider");
		counter += 1;
		//print (counter);
		Text score = GameObject.Find("Score").GetComponent<Text>();
		string scoreString = counter.ToString();
		score.text = "Score: " + scoreString;
		if (counter > 30) {
			animateText();
			Text finalText = GameObject.Find("youWin").GetComponent<Text>();
			string fin = "You Win!!";
			finalText.text = fin;

		}
		}
	void animateText(){
		animator1.SetInteger (anim1, 1);
	}
	void OnTriggerExit(Collider other){
		print ("exit");
	}
}
