using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StrLabelScript : MonoBehaviour {
	
	public static Text StrLabel;
	
	// Use this for initialization
	void Start () {
		StrLabel = GetComponent<Text>();
		StrLabel.text = "STR: ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
