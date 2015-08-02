using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DexLabelScript : MonoBehaviour {
	
	public static Text DexLabel;
	
	// Use this for initialization
	void Start () {

		DexLabel = GetComponent<Text>();
		DexLabel.text = "DEX: ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
