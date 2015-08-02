using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DexTextScript : MonoBehaviour {
	
	public static Text DexText;
	
	// Use this for initialization
	void Start () {
		DexText = GetComponent<Text>();
		DexText.text = "" + GameInformation.PlayerOneAS.dex;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
