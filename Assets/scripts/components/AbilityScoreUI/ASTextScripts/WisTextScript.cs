using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WisTextScript : MonoBehaviour {
	
	public static Text WisText;
	
	// Use this for initialization
	void Start () {
		WisText = GetComponent<Text>();
		WisText.text = "" + GameInformation.PlayerOneAS.wis;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
