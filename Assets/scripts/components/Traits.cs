using UnityEngine;
using System.Collections;

public class Traits : MonoBehaviour {

	public string name, charClass;
	public char sex;
	public int age, height, weight, feet, inches;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SetName (string name) {
		this.name = name;
	}
	
	public void SetClass (string charClass) { // additional attributes or consequences of class?
		this.charClass = charClass;
	}
	
	public void SetSex (char sex) {
		this.sex = sex;
	}
	
	public void SetAge (int age) {
		this.age = age;
	}

	public void SetWeight (int weight) {
		this.weight = weight;
	}

	public void SetHeight (int feet, int inches){
		this.feet = feet;
		this.inches = inches;
		this.height = ((feet * 60) + inches);
	}


	

}
