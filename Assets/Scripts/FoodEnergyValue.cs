using UnityEngine;
using System.Collections;

public class FoodEnergyValue : MonoBehaviour {
	
		
	public int energy = 1;
	public int maxEnergy = 5;
	public bool isFood = true;
	public float energyCounter = 0.0f;
	public float energyCreateTimer = 5.0f;
	public Rigidbody2D seedPrefab;
	private Vector2 seedPos;

	void Update(){

		energyCounter += Time.deltaTime;
		if (energyCounter >= energyCreateTimer){
			energyCounter = 0;
			Aqquire(1);

		}

		if (energy >= maxEnergy) {	     // Create seed


//			seedPos.x = (transform.position.x) + Random.Range(-1,1);
//			seedPos.y = (transform.position.y) + Random.Range(-1,1);			//this is shitty, try use radius
//			Instantiate(seedPrefab, seedPos, Quaternion.Euler(0,0,0));
//			Expend(2);
				}
		}
		
		public void Aqquire(int aqquisitionCount)
		{
			energy += aqquisitionCount;
			
			if (energy > maxEnergy)
			{
				energy = maxEnergy;
			}
		}
		
		public void Expend(int expendCount)
		{
			energy -= expendCount;
		
			if (energy <= 0)
			{
				// DEAD

				Destroy(gameObject);


			}
		}


	}
