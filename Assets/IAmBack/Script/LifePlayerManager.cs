using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LifePlayerManager : MonoBehaviour {

	private int life = 5;
	private int Gemas = 0;
	private float Score = 0;

	public Text infoScore;
	public Image[] golpe01 = new Image[5];

	public AudioSource tejodiste;
	public AudioSource casiteJodes;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if( life <= 0 ){
			life = 0;
		}
		if( life > 5 ){
			life = 5;
		}
			
		showDanger ( life );
		Score += Time.deltaTime;
		infoScore.text = ((int)Score).ToString ();
	}

	public void OnHit(){
		life -= 1;
		tejodiste.Play();
		if( life == 0 ){
			SceneManager.LoadScene ("GAMEOVER");
		}
	}

	public void teSalvaste(){
		life += 1;
		casiteJodes.Play ();
	}

	void showDanger( int number){

		for( int i = 0; i < 5 ; i++ ){
			golpe01 [i].gameObject.SetActive (false);
		}

		for( int i = 0; i < 5 -  number; i++ ){
			golpe01 [i].gameObject.SetActive (true);
		}
	}
}