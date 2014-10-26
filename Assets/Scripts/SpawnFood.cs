using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {

	public float foodSpawnRate = 3.0f;
	private float spawnCounter = 0.0f;
	public Rigidbody2D foodPrefab;
	private Vector2 foodPos;
	private float x;
	private float y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spawnCounter += Time.deltaTime;
		if (spawnCounter >= foodSpawnRate){
			CreateFood();
			spawnCounter = 0.0f;
		}
	}

	void CreateFood()
	{
		x = Random.Range (0.0f, 1.0f);
		y = Random.Range (0.0f, 1.0f);
		foodPos = Camera.main.ViewportToWorldPoint(new Vector2(x,y));
		Instantiate(foodPrefab, foodPos, Quaternion.Euler(0,0,0));

	}

}
