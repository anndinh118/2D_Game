using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BottomWallScript : MonoBehaviour {


	public static void KillPlayer (Player player) {
		Destroy (player.gameObject);

	 
		SceneManager.LoadScene (2);
	}
}
