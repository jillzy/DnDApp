using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteLabelScript : MonoBehaviour {
	
	public static Text InteLabel;
	
	// Use this for initialization
	void Start () {
		InteLabel = GetComponent<Text>();
		InteLabel.text = "INT: ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
