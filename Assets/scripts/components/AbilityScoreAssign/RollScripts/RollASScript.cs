using UnityEngine;
using System.Collections;

public class RollASScript : MonoBehaviour {
	
	public void RollStrAS() {

		int[] diceValues;
		int sumStr;

		/*Array of 7 elements indexed 0 - 6*/
		diceValues = new int[7];

		/*Assign value to corresponding die in array*/
		diceValues[1] = Random.Range (1, 7);
		diceValues[2] = Random.Range (1, 7);
		diceValues[3] = Random.Range (1, 7);
		diceValues[4] = Random.Range (1, 7);
		diceValues[5] = Random.Range (1, 7);
		diceValues[6] = Random.Range (1, 7);

		/*Call function that returns sum of three highest values*/
		sumStr = FindHighestThree(diceValues);

		ASUIUpdater.UpdateText("Str", sumStr);


		
	}
	
	int FindHighestThree(int[] diceValues) {

		int curMax;
		int maxIndex = 0;
		int[] highestThree;

		highestThree = new int[3];

		/*Perform loop three times for total of 3 values*/
		for (int i = 0; i < 3 ; i++) {
			/*curMax is some arbitrary value*/
			curMax = 0;
			/*Compare curMax with all elements in diceValue*/
			for (int j = 1; j <= 6; j++) {
				if (curMax <= diceValues[j]) {
					curMax = diceValues[j];
					maxIndex = j;
				}

			}
			/*At end of loop, we will get the max value in array
			 * put the value into highestThree*/
			highestThree[i] = curMax;
			/*"Clear" index of value we just took by setting to 0*/
			diceValues[maxIndex] = 0;
			
		}

		/*Sum up the highest three values and return*/
		return 	(highestThree [0] + highestThree [1] + highestThree [2]);
	}

	
}