using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public bool isPaused = false;

	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			PlayOrPause ();
		}
	}

	public void PlayOrPause () {
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
			isPaused = true;
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
			isPaused = false;
		}
	}

}
