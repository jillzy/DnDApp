using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ConLabelScript : MonoBehaviour {
	
	public static Text ConLabel;
	
	// Use this for initialization
	void Start () {
		ConLabel = GetComponent<Text>();
		ConLabel.text = "CON: ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
