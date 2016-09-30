using UnityEngine;
using System.Collections;

public class GeneradorMeteoros : MonoBehaviour {

	public GameObject meteor;
	private float tiempoMeteor;
	public float compararTiempo=1;
	private float tiempoInicio=0;
	public float tiempojuego=2;
	Vector3 posFinal;


	// Use this for initialization
	void Start () {
		//Instantiate (meteor);
	
	}
	
	// Update is called once per frame
	void Update () {

		//
		tiempoInicio+=Time.deltaTime;

		if (tiempoInicio > tiempojuego) {
			tiempoMeteor += Time.deltaTime;
			if (tiempoMeteor >= compararTiempo) {
				tiempoMeteor = 0;
				posFinal = transform.position;
				posFinal.x = Random.Range (-4.5f, 4.5f);


				Instantiate (meteor ,posFinal,Quaternion.identity);
				

			}
		}
	}
}
