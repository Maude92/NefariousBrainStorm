using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasEnd : MonoBehaviour {
	public Image bonhomme;
	public Image nuage;
	public Text about;
	public Text title;
	//public GameObject canvasMain;
	//public GameObject canvasLearnMore;
	//public GameObject canvasCredits;

	private AudioManager audioManager;


	void Start (){
		about.enabled = false;
		//Image bonhomme = bonhomme.GetComponent<Image>;
		//Text about = about.GetComponent<Text>;
		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}
	}

	// JOUER UN SON QUAND JE CLIQUE
	public void playClipButton () {
		audioManager.PlaySound ("SFX_MenuButton");
	}

	public void playClipStart(){
		audioManager.PlaySound ("SFX_MenuStart");
	}


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

	public void Menu(){
		SceneManager.LoadScene (0);
	}

	// POUR VOIR LES INFOS
	public void LearnMoreEnd(){
		bonhomme.enabled = false;
		title.enabled = false;
		nuage.enabled = false;
		about.enabled =true;
//		canvasMain.SetActive (false);
//		canvasCredits.SetActive (false);
//		canvasLearnMore.SetActive (true);
	}

	// POUR SORTIR DU CANVAS LEARN MORE
//	public void ExitLearnMore(){
//		canvasLearnMore.SetActive (false);
//		canvasCredits.SetActive (false);
//		canvasMain.SetActive (true);
//	}


	// POUR VOIR LES CREDITS
//	public void Credits(){
//		canvasMain.SetActive (false);
//		canvasLearnMore.SetActive (false);
//		canvasCredits.SetActive (true);
//	}

	// POUR SORTIR DU CANVAS CREDITS
//	public void ExitCredits(){
//		canvasCredits.SetActive (false);
//		canvasLearnMore.SetActive (false);
//		canvasMain.SetActive (true);
//	}


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
