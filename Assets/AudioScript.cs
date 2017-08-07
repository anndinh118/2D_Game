using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	public AudioSource Music;

	// Use this for initialization
	void Start () {
		if (!Music.isPlaying) {
			Music.Play ();
		}

		//if (AudioListner.pause) {
		//	AudioListner.pause = false;
		//}

		//if (!Music.loop) {
		//	Music.loop = true;
		//}
	}

	
	// Update is called once per frame
	void Update () {
		if (!Music.isPlaying) {
			Music.Play ();
		}
	}
}