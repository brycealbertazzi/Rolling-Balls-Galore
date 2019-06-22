using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour {

	public GameObject ball;
	public GameObject indesdructibleBall;

	private GameObject[] spawnPoints;
	private Rigidbody ballRigidBody;
	private Pause pause;
	private float threshold = 0.0007f;
	private float indestructibleThreshold = 0.0002f;
	private int ballVelocity;
	private int ballAngularVelocity;

	void Start () {
		ballRigidBody = ball.GetComponent<Rigidbody> ();
		spawnPoints = GameObject.FindGameObjectsWithTag ("Spawn Point");
		pause = FindObjectOfType<Pause> ();

		InvokeRepeating ("IncreaseDifficulty", 20, 20);
		ballVelocity = -120;
		ballAngularVelocity = 10;
	}

	// Update is called once per frame
	void Update () {
		if (pause.isPaused == false)
			InstantiateRollingBalls ();
	}
		
	void InstantiateRollingBalls() {
			foreach (GameObject spawn in spawnPoints) {
				float value = Random.value;
				if (value < threshold) {
					GameObject launchedBall = Instantiate (ball, spawn.transform.position, Quaternion.identity, spawn.transform) as GameObject;
					launchedBall.GetComponent<Rigidbody> ().velocity = new Vector3 (ballVelocity, 0, 0);
					launchedBall.GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, 0, ballAngularVelocity);
				}
				if (value < indestructibleThreshold) {
					GameObject indestructibleLaunchedBall = Instantiate (indesdructibleBall, spawn.transform.position, Quaternion.identity, spawn.transform) as GameObject;
					indestructibleLaunchedBall.GetComponent<Rigidbody> ().velocity = new Vector3 (ballVelocity, 0, 0);
					indestructibleLaunchedBall.GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0, 0, ballAngularVelocity);
				}
			}
	}
	void IncreaseDifficulty () {
		threshold += 0.00025f;
		indestructibleThreshold += 0.0000667f;
		ballVelocity -= 10;
		ballAngularVelocity += 10;
	}
}
