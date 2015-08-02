using UnityEngine;
using System.Collections;
//using Unity.UI;
using UnityEngine.UI;

/*also this script has to be attached to the text object in the heirarchy*/


public class ASUIUpdater : MonoBehaviour {
	

	public static void UpdateScoreAndText(int ability, int newValue) {

		//case switch instead of ifs
		switch (ability) {

			case 1: 
				GameInformation.PlayerOneAS.SetStr (newValue);
				//DisplayText("Str");
			StrTextScript.StrText.text = "" + GameInformation.PlayerOneAS.str;
				break;

			case 2:
				GameInformation.PlayerOneAS.SetDex (newValue);
			DexTextScript.DexText.text = "" + GameInformation.PlayerOneAS.dex;
				break;

			case 3:
				GameInformation.PlayerOneAS.SetCon (newValue);
			ConTextScript.ConText.text = "" +  GameInformation.PlayerOneAS.con;
				break;

			case 4:
				GameInformation.PlayerOneAS.SetInte (newValue);
			InteTextScript.InteText.text = "" +  GameInformation.PlayerOneAS.inte;
				break;

			case 5:
				GameInformation.PlayerOneAS.SetWis (newValue);
			WisTextScript.WisText.text = "" +  GameInformation.PlayerOneAS.wis;
				break;

			case 6:
				GameInformation.PlayerOneAS.SetCha (newValue);
			ChaTextScript.ChaText.text = "" +  GameInformation.PlayerOneAS.cha;
				break;	
		
			default: 
				break;	

		}
	}

	public void EnableRolling() {
		
		foreach (Transform child in transform) {
			child.gameObject.GetComponent<Button>().interactable = false;
		}
	}
}