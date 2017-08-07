using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectingCarrotScript : MonoBehaviour {

	private int score;

	public GUIText count;

	public int Carrot;

	void Start() {
		score = 0;
		UpdateCounter ();
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.CompareTag("Carrots")) {
			score += 1;
			UpdateCounter ();
			if (score == Carrot) {
				SceneManager.LoadScene (3);
			}
		}

	}

	void UpdateCounter()
	{
		count.text = "Carrots: " + score.ToString ();
	}
}

