using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indestructible : MonoBehaviour {

	private LevelManager levelManager;

	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter (Collision col){
		//Handles indestructible ball hitting player
		if (col.gameObject.tag == "Player") {
			LoadLose ();
		} 
	}

	void OnTriggerEnter (Collider col) {
		//Handles indestructible ball hitting shredder
		if (col.gameObject.tag == "Shredder")
			Destroy (gameObject);
	} 

	void LoadLose(){
		Destroy (gameObject);
		Period.gameOn = false;
		levelManager.LoadLevel ("Lose");
	}

}
