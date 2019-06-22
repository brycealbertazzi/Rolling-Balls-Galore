using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int playerMoveAmount;
	public int bulletVelocity;

	private GameObject bullet;
	private Pause pause;

	float zMin = -293;
	float zMax = 293;

	void Start () {
		bullet = GameObject.FindGameObjectWithTag ("Bullet");
		pause = FindObjectOfType<Pause> ();
	}

	void Update () {
		//Prevents player from going off the platform
		transform.position = new Vector3 (transform.position.x, transform.position.y,  Mathf.Clamp (transform.position.z, zMin, zMax));
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			MoveLeft ();
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			MoveRight ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			FireBullet ();
		}
	}

	public void MoveRight () {
		if (pause.isPaused == false)
			transform.position -= new Vector3 (0, 0, playerMoveAmount);
	}

	public void MoveLeft() {
		if (pause.isPaused == false)
			transform.position += new Vector3 (0, 0, playerMoveAmount);
	}

	public void FireBullet () {
		if (pause.isPaused == false) {
			Vector3 offset = new Vector3 (9f, -8.4f, 0f);
			GameObject capsule = Instantiate (bullet, transform.position + offset, Quaternion.Euler (new Vector3 (0, 0, 90))) as GameObject;
			capsule.GetComponent<Rigidbody> ().velocity = new Vector3 (bulletVelocity, 0, 0);
			foreach (AudioSource audio in GameObject.FindObjectsOfType<AudioSource>()) {
				if (audio.priority == 150)
					audio.Play ();
			}
				
				
		}
	}
		
		 
}
