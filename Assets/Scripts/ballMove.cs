using UnityEngine;
using System.Collections;

public class ballMove : MonoBehaviour {

	Rigidbody2D rb;

	bool isTouchingGoalie = false;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isTouchingGoalie == true && Input.GetKey ("space")) {
			rb.velocity = new Vector3 (0, 350, 0);
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "goalie") {
			isTouchingGoalie = true;
		} else {
			isTouchingGoalie = false;
		}
	}
}
