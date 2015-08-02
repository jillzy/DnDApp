using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StrTextScript : MonoBehaviour {
	
	public static Text StrText;

	// Use this for initialization
	void Start () {
		StrText = GetComponent<Text>();
		StrText.text = "" + GameInformation.PlayerOneAS.str;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
