using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour {

	private AudioSource audioSource;
	private LevelManager levelManager;

	void Start () {
		audioSource = GetComponent<AudioSource> ();
		levelManager = FindObjectOfType<LevelManager> ();
		audioSource.Play ();
		Invoke ("StartFromSplash", audioSource.clip.length);
	}

	void StartFromSplash () {
		levelManager.LoadLevel ("Start");
	}
	

}
