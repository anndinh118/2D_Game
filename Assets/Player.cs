using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int curHealth;
	public int maxHealth = 100;


	void Start () {
		curHealth = maxHealth;
	}

	public class PlayerStats {

		public int Health = 100;
	}

	public PlayerStats playerStats = new PlayerStats();

	public int fallBoundary = -1;

	void Update () {
		if (transform.position.y <= fallBoundary) {
			DamagePlayer (9999999);
		}

	/*	if (curHealth > maxHealth) {
			curHealth = maxHealth;
		}

		if (curHealth <= 0) {
			Die();
		} */
	}

	public void DamagePlayer(int damage) {
		playerStats.Health -= damage;
		if (playerStats.Health <= 0) {
			BottomWallScript.KillPlayer (this);

		}
	
	}

	void Die () {
		Application.LoadLevel (Application.loadedLevel); 	// restart 
	}

}
