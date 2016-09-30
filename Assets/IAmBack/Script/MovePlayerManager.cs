using UnityEngine;
using System.Collections;

public class MovePlayerManager : MonoBehaviour {

	private float deltaTime = 0.1F;
	private float deltaForce = 6.0F;
	// Use this for initialization
	void Start () {
	
	}
		
	// Update is called once per frame
	void Update () {
		//if( Time.time > deltaTime && Input.GetKey(KeyCode.LeftArrow) ){
		if( (Input.acceleration.x < 0.0F) ){
			gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.left * deltaForce);
			//deltaTime = Time.time + 0.1F;
		}
			
		//if( Time.time > deltaTime && Input.GetKey(KeyCode.RightArrow) ){
		if( (Input.acceleration.x > 0.0F) ){
			gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.right * deltaForce);
			//deltaTime = Time.time + 0.1F;
		}
	}
}