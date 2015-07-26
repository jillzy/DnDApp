using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Start() {

		/*PlayerOneAS = new AbilityScores();
		PlayerOneAS.SetStr(1);
		PlayerOneAS.SetDex(2);
		PlayerOneAS.SetCon(3);
		PlayerOneAS.SetInte(4);
		PlayerOneAS.SetWis(10);
		PlayerOneAS.SetCha(7);

		PlayerOneTraits = new Traits();
		PlayerOneTraits.SetName("Electra Boogaloo");
		PlayerOneTraits.SetClass ("Cat gal");
		PlayerOneTraits.SetSex ('F');
		PlayerOneTraits.SetWeight (90);
		PlayerOneTraits.SetHeight (5,0);

		SaveAndLoadManager.SavePlayerInfo();*/


		SaveAndLoadManager.LoadPlayerInfo();


	}

	public void SavePlayerInfo() {
		SaveAndLoadManager.SavePlayerInfo ();
	}

	public void LoadPlayerInfo() {
		SaveAndLoadManager.LoadPlayerInfo ();
	}


	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	
	public static AbilityScores PlayerOneAS {get;set;}
	public static Traits PlayerOneTraits {get;set;}
	
}