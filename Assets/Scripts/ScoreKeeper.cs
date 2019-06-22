using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	public static int score;

	private Text text;
	private Ball ball;

	void Start () {
		text = GetComponent<Text> ();
		ball = FindObjectOfType<Ball> ();

		text.text = score.ToString ();
	}
	
	void Update () {
		text.text = score.ToString ();
	}
	public void UpdateScore(int myScore){
		score += myScore;
	} 

	public void Reset() {
		score = 0;
}
}