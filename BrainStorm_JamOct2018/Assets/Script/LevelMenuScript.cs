using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenuScript : MonoBehaviour {

	public GameObject canvasPause;
	public GameObject canvasEndOfGame;
	public GameObject playerNuage;

	//public bool modePause;

	ControlsPlayer controlsplayerscript;

	private AudioManager audioManager;


	// Use this for initialization
	void Start () {
		//modePause = false;
		//Time.timeScale = 1;

		controlsplayerscript = playerNuage.GetComponent<ControlsPlayer> ();

		audioManager = AudioManager.instance;
		if (audioManager == null) {
			Debug.LogError ("Attention, le AudioManager n'a pas été trouvé dans la scène.");}
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetButtonDown ("360_StartButton") || Input.GetKeyDown (KeyCode.Escape)) {
//			controlsplayerscript.modePause = !controlsplayerscript.modePause;
//
//			if (controlsplayerscript.modePause == true) {
//				controlsplayerscript.enabled = false;
//				// désactiver UI inutile
//				canvasPause.SetActive (true);
//				Time.timeScale = 0;
//			} else if (controlsplayerscript.modePause == false) {
//				Time.timeScale = 1;
//				canvasPause.SetActive (true);
//				// réactiver canvas utile
//				controlsplayerscript.enabled = true;
//			}
//		}
	}

	// POUR QUITTER LE JEU :(
	public void QuitGame(){
		print ("Bye bye! :(");
		Application.Quit ();
	}


	// POUR RETOURNER AU MAIN MENU
	public void MainMenu(){
		// SceneManager.LoadScene (0);
		SceneManager.LoadSceneAsync (0);
		// Set active le loading screen
	}


	// POUR METTRE LE JEU EN PAUSE / RECOMMENCER À JOUER
	public void ResumeGame(){
		Time.timeScale = 1;
		canvasPause.SetActive (false);
		controlsplayerscript.modePause = !controlsplayerscript.modePause;
	}

	

}
