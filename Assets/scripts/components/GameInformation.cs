using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Start() {

		/*PlayerOneStats = new Stats();
		PlayerOneStats.SetStr(1);
		PlayerOneStats.SetDex(2);
		PlayerOneStats.SetCon(3);
		PlayerOneStats.SetInte(4);
		PlayerOneStats.SetWis(10);
		PlayerOneStats.SetCha(7);

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
	
	public static Stats PlayerOneStats {get;set;}
	public static Traits PlayerOneTraits {get;set;}
	
}