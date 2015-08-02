using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IncrementAS : MonoBehaviour {



	int newValue = 0;
	
	void Start() {
		
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Button>().interactable = false;
		}
		
	}


	public void IncrementScore(int ability) {
		
		switch (ability) {
			
		case 1: 
			newValue = (GameInformation.PlayerOneAS.str + 1) % 19;
			ASUIUpdater.UpdateScoreAndText (1, newValue);
			break;
			
		case 2:
			newValue = (GameInformation.PlayerOneAS.dex + 1) % 19;
			ASUIUpdater.UpdateScoreAndText (2, newValue);
			break;
			
			
		case 3:
			newValue = (GameInformation.PlayerOneAS.con + 1) % 19;
			ASUIUpdater.UpdateScoreAndText (3, newValue);
			break;
			
			
		case 4:
			newValue = (GameInformation.PlayerOneAS.inte + 1) % 19;
			ASUIUpdater.UpdateScoreAndText (4, newValue);
			break;
			
		case 5:
			newValue = (GameInformation.PlayerOneAS.wis + 1) % 19;
			ASUIUpdater.UpdateScoreAndText (5, newValue);
			break;
			
		case 6:
			newValue = (GameInformation.PlayerOneAS.cha + 1) % 19;
			ASUIUpdater.UpdateScoreAndText (6, newValue);
			break;	
			
		default: 
			break;	
		}
	}


	public void EnableIncrement() {
		
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Button>().interactable = true;
		}
	}


	public void DisableIncrement() {
		
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Button>().interactable = false;
		}
	}

}
