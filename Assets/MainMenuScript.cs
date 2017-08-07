using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public Button Play;
	public Button Exit;
	public Button PlayAgain;
	public Button MainMenu;


	void Start () {
		Play = Play.GetComponent<Button> ();
		Exit = Exit.GetComponent<Button> ();
		PlayAgain = PlayAgain.GetComponent<Button> ();
		MainMenu = MainMenu.GetComponent<Button> ();
	}
	
	public void PlayButton() {
		SceneManager.LoadScene (1);
	}

	public void ExitButton() {
		Application.Quit ();
	}

	public void PlayAgainButton() {
		SceneManager.LoadScene (1);
	}

	public void MainMenuButton() {
		SceneManager.LoadScene (0);
	}

	public void CreditScene() {
		SceneManager.LoadScene (4);
	}
}
