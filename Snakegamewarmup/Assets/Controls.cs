using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	public Vector3 heading = Vector3.zero;
	public double speed = 1;
	int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("up") && heading != Vector3.down){
			heading = Vector3.up;
		}
		if(Input.GetKey("down") && heading != Vector3.up){
			heading = Vector3.down;
		}
		if(Input.GetKey("left") && heading != Vector3.right){
			heading = Vector3.left;
		}
		if(Input.GetKey("right") && heading != Vector3.left){
			heading = Vector3.right;
		}

		// Move forwards
		transform.Translate(heading);
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "food") {
			MoveFood();
		} else {
			heading = -heading;
		}
	}

	void MoveFood(){
		score++;
		print (score);
		GameObject.Find("food").transform.position = new Vector3(Random.Range(-63, 63), Random.Range(-29, 29), 0);
	}
}
