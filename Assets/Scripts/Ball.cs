using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


	private Period period;
	private ScoreKeeper scoreKeeper;
	private LevelManager levelManager;
	private Player player;

	void Start () {
		period = FindObjectOfType<Period> ();
		scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		levelManager = FindObjectOfType<LevelManager> ();
		player = FindObjectOfType<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider col){
		//Handles bullet hitting ball
		if (col.gameObject.tag == "Bullet") {
			scoreKeeper.UpdateScore (Period.period * 5);
			player.GetComponent<AudioSource> ().Play ();
		}
		Destroy (gameObject);
	}

	void OnCollisionEnter (Collision col){
		//Handles ball hitting player
		if (col.gameObject.tag == "Player") {
			LoadLose ();
		}
	}

	void LoadLose(){
		Destroy (gameObject);
		Period.gameOn = false;
		levelManager.LoadLevel ("Lose");
	}
}
