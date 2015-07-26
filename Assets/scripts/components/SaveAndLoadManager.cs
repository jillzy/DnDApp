using UnityEngine;
using System.Collections;

public static class SaveAndLoadManager{
	
	public static void SavePlayerInfo() {

		PPSerialization.Save("ABILITYSCORES", GameInformation.PlayerOneAS);
		PPSerialization.Save("TRAITS", GameInformation.PlayerOneTraits);

	}

	public static void LoadPlayerInfo () {
		GameInformation.PlayerOneAS = (AbilityScores) PPSerialization.Load("ABILITYSCORES");
		GameInformation.PlayerOneTraits = (Traits) PPSerialization.Load("TRAITS");
	}
}
