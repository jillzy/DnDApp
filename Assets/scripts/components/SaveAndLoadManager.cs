using UnityEngine;
using System.Collections;

public static class SaveAndLoadManager{
	
	public static void SavePlayerInfo() {

		PPSerialization.Save("STATS", GameInformation.PlayerOneStats);
		PPSerialization.Save("TRAITS", GameInformation.PlayerOneTraits);

	}

	public static void LoadPlayerInfo () {
		GameInformation.PlayerOneStats = (Stats) PPSerialization.Load("STATS");
		GameInformation.PlayerOneTraits = (Traits) PPSerialization.Load("TRAITS");
	}
}
