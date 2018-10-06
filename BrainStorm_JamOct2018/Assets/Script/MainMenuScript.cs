using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	public GameObject canvasMain;
	public GameObject canvasLearnMore;
	public GameObject canvasCredits;


	// POUR COMMENCER LE JEU
	public void StartGame(){
		//SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex + 1);
		//StartCoroutine (LoadAsyncStart ());
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex + 1);
	}

//	IEnumerator LoadAsyncStart (){
//		AsyncOperation operation = SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex + 1);
//		// Set active le loading screen
//	}


	// POUR VOIR LES INFOS
	public void LearnMore(){
		canvasMain.SetActive (false);
		canvasCredits.SetActive (false);
		canvasLearnMore.SetActive (true);
	}

	// POUR SORTIR DU CANVAS LEARN MORE
	public void ExitLearnMore(){
		canvasLearnMore.SetActive (false);
		canvasCredits.SetActive (false);
		canvasMain.SetActive (true);
	}


	// POUR VOIR LES CREDITS
	public void Credits(){
		canvasMain.SetActive (false);
		canvasLearnMore.SetActive (false);
		canvasCredits.SetActive (true);
	}

	// POUR SORTIR DU CANVAS CREDITS
	public void ExitCredits(){
		canvasCredits.SetActive (false);
		canvasLearnMore.SetActive (false);
		canvasMain.SetActive (true);
	}


	// POUR QUITTER LE JEU :(
	public void QuitGame(){
		print ("Bye bye! :(");
		Application.Quit ();
	}


//	// POUR RETOURNER AU MAIN MENU
//	public void MainMenu(){
//		// SceneManager.LoadScene (0);
//		StartCoroutine (LoadAsyncMainMenu ());
//	}
//
//	IEnumerator LoadAsyncMainMenu(){
//		AsyncOperation operation = SceneManager.LoadSceneAsync (0);
//		// Set active le loadinf screen
//	}

}
