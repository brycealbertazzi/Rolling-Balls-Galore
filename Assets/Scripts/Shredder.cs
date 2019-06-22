using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

	void OnCollisionEnter(Collision col){
			Destroy (col.gameObject);
		
	} 

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Bullet") {
			Destroy (col.gameObject);
		}
	}

}
