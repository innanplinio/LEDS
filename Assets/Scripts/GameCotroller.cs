using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCotroller : MonoBehaviour {

	public TextMesh scoretxt;
	public int Score;
	private int Vidas = 3;
	public Mosquito m;
	public GameObject startGame, score, instanciador,titulo;

	public GameObject gameOver;



	// Use this for initialization
	void Start () {
		m = FindObjectOfType (typeof(Mosquito)) as Mosquito;
	}


	// Update is called once per frame
	void Update () {


		scoretxt.text = Score.ToString();
		if (Vidas == 0) {
			instanciador.SetActive (false);
			gameOver.SetActive (true);
			Score = 0;
			returnToMenu ();
		}


	}
	public void addScore (){
		Score++;
	}
	public void perdeVida(){
		Vidas--;
	}

	public void returnToMenu(){
		startGame.SetActive (true);
		score.SetActive (false);
		titulo.SetActive (true);
	
	}
}
