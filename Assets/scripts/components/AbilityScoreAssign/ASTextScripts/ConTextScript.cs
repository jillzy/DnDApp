using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConTextScript : MonoBehaviour {
	
	public static Text ConText;
	
	// Use this for initialization
	void Start () {
		ConText = GetComponent<Text>();
		ConText.text = "CON: " + GameInformation.PlayerOneAS.con;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
