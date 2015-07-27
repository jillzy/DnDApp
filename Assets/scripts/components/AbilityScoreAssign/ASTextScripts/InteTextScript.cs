using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteTextScript : MonoBehaviour {

	public static Text InteText;
	
	// Use this for initialization
	void Start () {
		InteText = GetComponent<Text>();
		InteText.text = "INT: " + GameInformation.PlayerOneAS.inte;
	}


	// Update is called once per frame
	void Update () {
		
	}
}
