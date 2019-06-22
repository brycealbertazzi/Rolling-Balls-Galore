using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Period : MonoBehaviour {

	public static int period;
	public static bool gameOn = false;

	private Text text;
	private ScoreKeeper scoreKeeper;

	void Start () {
		text = GetComponent<Text> ();
		scoreKeeper = FindObjectOfType<ScoreKeeper> ();

		text.text = period.ToString ();
		if (gameOn == true) {
			period = 1;
			scoreKeeper.Reset ();
			InvokeRepeating ("UpdatePeriod", 20, 20);
		}
	}
	
	void Update () {
		text.text = period.ToString ();
	}

	public void UpdatePeriod() {
		period++;
		text.text = period.ToString ();
	}
	public void Reset() {
		period = 1;
	}
}
