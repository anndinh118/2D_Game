using UnityEngine;
using System.Collections;

public class CarrotDestroy : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {

		Destroy (gameObject);

	
	}
}
