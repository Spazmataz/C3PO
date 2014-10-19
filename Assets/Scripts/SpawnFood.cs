using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {

	public float foodSpawnRate = 3.0f;
	private float spawnCounter = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spawnCounter += Time.deltaTime;
		if (spawnCounter >= foodSpawnRate){
			CreateFood();
		}
	}

	void CreateFood()
	{

	}

}
