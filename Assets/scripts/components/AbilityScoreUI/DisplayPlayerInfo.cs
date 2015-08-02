using UnityEngine;
using System.Collections;

public class DisplayPlayerInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnGUI(){
		GUI.Label(new Rect(0,0,Screen.width,Screen.height),
			"STR: " + GameInformation.PlayerOneAS.str +
			"\nDEX: " + GameInformation.PlayerOneAS.dex +
			"\nCON: " + GameInformation.PlayerOneAS.con +
			"\nINT: " + GameInformation.PlayerOneAS.inte +
			"\nWIS: " + GameInformation.PlayerOneAS.wis +
			"\nCHA: " + GameInformation.PlayerOneAS.cha);
	}
}
