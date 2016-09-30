using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {

	public float velocidad;
	public float velocidad_rotacion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,velocidad*Time.deltaTime,0),Space.World);
		transform.Rotate (new Vector3 (0, 0, velocidad_rotacion * Time.deltaTime));
		//print (Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D colision){

		print("choco");

		if (colision.tag == "matador") {
			Destroy (gameObject);

		}

		if (colision.tag == "Player") {

			if (gameObject.tag == "Respawn") {
				colision.SendMessage ("teSalvaste");
			} else {
				colision.SendMessage ("OnHit");
			}

			Destroy (gameObject);
		}


	}


}
