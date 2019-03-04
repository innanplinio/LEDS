using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosquito : MonoBehaviour {

	public GameObject Morte;
	public GameCotroller gc ;
	public bool isActive;


	// Use this for initialization
	void Start () {
		gc = FindObjectOfType (typeof(GameCotroller))as GameCotroller;
		isActive = true;
	}
	
	// Update is called once per frame
	void Update () {


		if (gameObject.transform.position.x > 9) {
			Destroy (gameObject);
			gc.perdeVida ();
		}
		
	}

	private void OnMouseDown(){
		if (isActive) {
			Morte = Instantiate (Morte, transform.position, Quaternion.Euler (0, 180, 0));
			Destroy (gameObject);
			gc.addScore ();
		}
	}



}

