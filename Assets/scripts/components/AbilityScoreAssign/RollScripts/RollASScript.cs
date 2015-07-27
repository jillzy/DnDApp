using UnityEngine;
using System.Collections;

public class RollASScript : MonoBehaviour {
	
	public void RollAS(int ability) {
		
		int[] diceValues;
		int sumStr;
		
		/*Array of 7 elements indexed 0 - 4*/
		diceValues = new int[5];
		
		/*Assign value to corresponding die in array*/
		diceValues[1] = Random.Range (1, 7);
		diceValues[2] = Random.Range (1, 7);
		diceValues[3] = Random.Range (1, 7);
		diceValues[4] = Random.Range (1, 7);
		
		
		/*Call function that returns sum of three highest values*/
		sumStr = FindHighestThree(diceValues);
		
		
		switch (ability) {
			
		case 1: 
			ASUIUpdater.UpdateScoreAndText(1, sumStr);
			break;
			
		case 2:
			ASUIUpdater.UpdateScoreAndText(2, sumStr);
			break;
			
		case 3:
			ASUIUpdater.UpdateScoreAndText(3, sumStr);
			break;
			
		case 4:
			ASUIUpdater.UpdateScoreAndText(4, sumStr);
			break;
			
		case 5:
			ASUIUpdater.UpdateScoreAndText(5, sumStr);
			break;
			
		case 6:
			ASUIUpdater.UpdateScoreAndText(6, sumStr);
			break;	
			
		default: 
			break;	
			
		}
		
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
		for (int j = 1; j <= 4; j++) {
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