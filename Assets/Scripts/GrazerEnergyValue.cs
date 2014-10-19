using UnityEngine;
using System.Collections;

public class GrazerEnergyValue : MonoBehaviour {

	/// <summary>
	/// Total hitpoints
	/// </summary>
	public int energy = 1;
	public int maxEnergy = 5;
	public float eatRate = 1.0f;
	private float eatCounter = 0f;
	public bool isFood = true;
	

	

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
	

	void OnTriggerStay2D(Collider2D otherCollider)
	{



		FoodEnergyValue thing = otherCollider.gameObject.GetComponent<FoodEnergyValue>();
		if (thing != null) {

			if (thing.isFood == true){
				eatCounter += Time.deltaTime;
			if (eatCounter >= eatRate){
			
			Aqquire(1);
			thing.Expend(1);
			eatCounter = 0.0f;

			
			}
			}
		}
	}
}
