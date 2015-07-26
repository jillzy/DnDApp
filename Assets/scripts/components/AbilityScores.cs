using UnityEngine;
using System.Collections;



[System.Serializable]
public class AbilityScores{

	public int str, dex, con, inte, wis, cha;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetStr (int str) {
		this.str = str;
	}

	public void SetDex (int dex) {
		this.dex = dex;
	}

	public void SetCon (int con) {
		this.con = con;
	}

	public void SetInte (int inte) {
		this.inte = inte;
	}

	public void SetWis (int wis) {
		this.wis = wis;
	}

	public void SetCha (int cha) {
		this.cha = cha;
	}

	public int Roll() {
		return Random.Range (1, 7);
	}

	public int RollStr () {
		return (Roll() + this.str);
	}

	public int RollDex () {
		return (Roll() + this.dex);
	}

	public int RollCon () {
		return (Roll() + this.con);
	}

	public int RollInte () {
		return (Roll() + this.inte);
	}

	public int RollWis () {
		return (Roll() + this.wis);
	}

	public int RollCha () {
		return (Roll() + this.cha);
	}

}