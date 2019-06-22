using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	private int currentScore;
	private static int highScore;
	private Text text;
	private const string HIGH_SCORE_KEY = "HighScoreKey";

	void Start () {
		highScore = PlayerPrefs.GetInt (HIGH_SCORE_KEY);
		text = GetComponent<Text> ();

		currentScore = ScoreKeeper.score;

		if (currentScore > PlayerPrefs.GetInt (HIGH_SCORE_KEY)) {
			PlayerPrefs.SetInt (HIGH_SCORE_KEY, currentScore);
			highScore = PlayerPrefs.GetInt (HIGH_SCORE_KEY);
		}
		text.text = highScore.ToString ();
	}

	
}
