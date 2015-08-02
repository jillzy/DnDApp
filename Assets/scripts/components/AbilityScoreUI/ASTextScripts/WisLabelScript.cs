using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WisLabelScript : MonoBehaviour {
	
	public static Text WisLabel;
	
	// Use this for initialization
	void Start () {
		WisLabel = GetComponent<Text>();
		WisLabel.text = "WIS: ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
