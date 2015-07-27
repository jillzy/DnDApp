using UnityEngine;
using System.Collections;

public class IncrementAS : MonoBehaviour {

	int newValue = 0;
	

	public void IncrementScore(int ability) {

		switch (ability) {
		
			case 1: 
				if (GameInformation.PlayerOneAS.str == 18) { 
					ASUIUpdater.UpdateScoreAndText (1, 0);
				} else {
					newValue = GameInformation.PlayerOneAS.str + 1;
					ASUIUpdater.UpdateScoreAndText (1, newValue);
				}
				break;
		
			case 2:
				newValue = GameInformation.PlayerOneAS.dex + 1;
				ASUIUpdater.UpdateScoreAndText (2, newValue);
				break;
				
		
			case 3:
				newValue = GameInformation.PlayerOneAS.con + 1;
				ASUIUpdater.UpdateScoreAndText (3, newValue);
				break;
				

			case 4:
				newValue = GameInformation.PlayerOneAS.inte + 1;
				ASUIUpdater.UpdateScoreAndText (4, newValue);
				break;
				
			case 5:
				newValue = GameInformation.PlayerOneAS.wis + 1;
				ASUIUpdater.UpdateScoreAndText (5, newValue);
				break;
				
			case 6:
				newValue = GameInformation.PlayerOneAS.cha + 1;
				ASUIUpdater.UpdateScoreAndText (6, newValue);
				break;	
				
			default: 
				break;	
		}
	}
}
