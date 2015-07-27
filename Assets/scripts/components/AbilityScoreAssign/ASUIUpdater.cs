using UnityEngine;
using System.Collections;
//using Unity.UI;
using UnityEngine.UI;

/*also this script has to be attached to the text object in the heirarchy*/


public class ASUIUpdater : MonoBehaviour {
	

	public static void UpdateText(string abilityScore, int newValue) {

		//case switch instead of ifs
		switch (abilityScore) {

			case "Str": 
				GameInformation.PlayerOneAS.SetStr (newValue);
				//DisplayText("Str");
				StrTextScript.StrText.text = "STR: " + GameInformation.PlayerOneAS.str;
				break;

			case "Dex":
				GameInformation.PlayerOneAS.SetDex (newValue);
				DexTextScript.DexText.text = "DEX: " + GameInformation.PlayerOneAS.dex;
				break;

			case "Con":
				GameInformation.PlayerOneAS.SetCon (newValue);
				ConTextScript.ConText.text = "CON: " + GameInformation.PlayerOneAS.con;
				break;

			case "Inte":
				GameInformation.PlayerOneAS.SetInte (newValue);
				InteTextScript.InteText.text = "INT: " + GameInformation.PlayerOneAS.inte;
				break;

			case "Wis":
				GameInformation.PlayerOneAS.SetWis (newValue);
				WisTextScript.WisText.text = "WIS: " + GameInformation.PlayerOneAS.wis;
				break;

			case "Cha":
				GameInformation.PlayerOneAS.SetCha (newValue);
				ChaTextScript.ChaText.text = "CHA: " + GameInformation.PlayerOneAS.cha;
				break;	
		
			default: 
				break;	

		}
	}
}