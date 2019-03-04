using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public GameObject startGame, score, instanciador, gameOver, titulo;
	public Mosquito m;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		m = FindObjectOfType (typeof(Mosquito))as Mosquito;
		
	}

	public void OnMouseDown(){
		startGame.SetActive (false);
		score.SetActive (true);
		instanciador.SetActive (true);
		gameOver.SetActive (false);
		titulo.SetActive (false);
		instanciador.SetActive (true);
	}


}
