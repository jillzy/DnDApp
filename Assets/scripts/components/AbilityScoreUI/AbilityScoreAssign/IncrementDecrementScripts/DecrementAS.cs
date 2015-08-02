using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DecrementAS : MonoBehaviour {

	
	int newValue = 0;

	void Start() {
		
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Button>().interactable = false;
		}
		
	}

	public void DecrementScore(int ability) {
		
		switch (ability) {
		case 1: 
			newValue = (int) Mod(GameInformation.PlayerOneAS.str - 1, 19);
			ASUIUpdater.UpdateScoreAndText (1, newValue);
			break;
			
		case 2:
			newValue = (int) Mod(GameInformation.PlayerOneAS.dex - 1, 19);
			ASUIUpdater.UpdateScoreAndText (2, newValue);
			break;
			
			
		case 3:
			newValue = (int) Mod(GameInformation.PlayerOneAS.con - 1, 19);
			ASUIUpdater.UpdateScoreAndText (3, newValue);
			break;
			
			
		case 4:
			newValue = (int) Mod(GameInformation.PlayerOneAS.inte - 1, 19);
			ASUIUpdater.UpdateScoreAndText (4, newValue);
			break;
			
		case 5:
			newValue = (int) Mod(GameInformation.PlayerOneAS.wis - 1, 19);
			ASUIUpdater.UpdateScoreAndText (5, newValue);
			break;
			
		case 6:
			newValue = (int) Mod(GameInformation.PlayerOneAS.cha - 1, 19);
			ASUIUpdater.UpdateScoreAndText (6, newValue);
			break;	
			
		default: 
			break;	
		}
	}
	
	float Mod(float a, float b) {
		return a - b * Mathf.Floor (a / b);
	}


	public void EnableDecrement() {
		
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Button>().interactable = true;
		}
	}


	public void DisableDecrement() {
		
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Button>().interactable = false;
		}
	}
}
