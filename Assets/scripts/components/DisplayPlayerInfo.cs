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
			"STR: " + GameInformation.PlayerOneStats.str +
			"\nDEX: " + GameInformation.PlayerOneStats.dex +
			"\nCON: " + GameInformation.PlayerOneStats.con +
			"\nINT: " + GameInformation.PlayerOneStats.inte +
			"\nWIS: " + GameInformation.PlayerOneStats.wis +
			"\nCHA: " + GameInformation.PlayerOneStats.cha);
	}
}
