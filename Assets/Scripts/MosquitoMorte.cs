using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosquitoMorte : MonoBehaviour {

	private float startime = 0.3f;
	private float current;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		current += Time.deltaTime;

		if (current > startime)
			Destroy (gameObject);
	}
}
