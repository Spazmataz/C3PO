using UnityEngine;
using System.Collections;

public class FoodEnergyValue : MonoBehaviour {
	
		/// <summary>
		/// Total hitpoints
		/// </summary>
		public int energy = 1;
		public int maxEnergy = 5;

		/// <summary>
		/// Enemy or player?
		/// </summary>
		

		public bool isFood = true;

		
		/// <summary>
		/// Inflicts damage and check if the object should be destroyed
		/// </summary>
		/// <param name="damageCount"></param>
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
			//transform.position = transform.position + new Vector3(1f, 1f, 0f);
				Destroy(gameObject);


			}
		}


	}
