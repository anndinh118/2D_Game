using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesScript : MonoBehaviour {

	private int tally;

	public GUIText count;

	public int lives;

	void Start() {
		tally = 3;
		UpdateCounter ();
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.CompareTag("Lives")) {
			tally -= 1;
			UpdateCounter ();
			if (tally == lives) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}

	public static void KillPlayer (Player player) {
		Destroy (player.gameObject);
	}

	void UpdateCounter() {
		count.text = "LIVES: " + tally.ToString ();
	}

}
