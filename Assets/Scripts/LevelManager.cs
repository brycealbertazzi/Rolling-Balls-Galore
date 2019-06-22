using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	Period period;
	ScoreKeeper scoreKeeper;

	void Start () {
		period = FindObjectOfType<Period> ();
		scoreKeeper = FindObjectOfType<ScoreKeeper> ();
	}

	public void LoadLevel(string name){
		Application.LoadLevel (name);
	}

	public void LoadGame() {
		Period.gameOn = true;
		Application.LoadLevel ("Game");
	}
		
}
