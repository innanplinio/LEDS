using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour {

	public float minSpawnTime, maxSpawnTime;
	public float spawnItem;

	public GameObject[] Itens;
	private GameObject item;
	private int index;
	private int count;

	public float upForce= 400f;
	public float  leftForce = 200f;

	// Use this for initialization'
	void Start () {

		StartCoroutine ("Instanciador");
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	bool RandomItem(){
		if (Itens.Length > 0) {
			index = Random.Range (0, Itens.Length);
			return true;
		}
		return false;
	}

	private IEnumerator Instanciador(){

		spawnItem = Random.Range (minSpawnTime, maxSpawnTime);

		yield return new WaitForSeconds (spawnItem);
		if (RandomItem ()) {
			item = Instantiate (Itens [index], new Vector2 (-8, Random.Range (-4.5f, 3.3f)), Quaternion.Euler(0,180,0))as GameObject;
			//item.transform.rotation.eulerAngles;
			if (item.transform.position.x > 0) {

				item.GetComponent<Rigidbody2D>().AddForce(new Vector2(-(Random.Range(200f,400f)),0));

			}else{
				item.GetComponent<Rigidbody2D>().AddForce (new Vector2 (Random.Range(200f,400f), 0));
			}
		}
		StartCoroutine("Instanciador");

	}
		
}
