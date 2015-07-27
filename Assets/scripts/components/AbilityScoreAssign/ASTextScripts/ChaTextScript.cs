using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChaTextScript : MonoBehaviour {
	
	public static Text ChaText;
	
	// Use this for initialization
	void Start () {
		ChaText = GetComponent<Text>();
		ChaText.text = "CHA: " + GameInformation.PlayerOneAS.cha;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
