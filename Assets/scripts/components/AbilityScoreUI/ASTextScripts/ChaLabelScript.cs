using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChaLabelScript : MonoBehaviour {
	
	public static Text ChaLabel;
	
	// Use this for initialization
	void Start () {
		ChaLabel = GetComponent<Text>();
		ChaLabel.text = "CHA: ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
