using UnityEngine;


[System.Serializable]
public class Sound {

	public string name;
	public AudioClip clip;

	[Range(0f, 1f)]
	public float volume = 0.7f;
	[Range(0.5f, 1.5f)]
	public float pitch = 1f;

	[Range(0f, 0.5f)]
	public float randomVolume = 0.1f;
	[Range(0f, 0.5f)]
	public float randomPitch = 0.1f;

	private AudioSource source;

	public void SetSource (AudioSource _source) {
		source = _source;
		source.clip = clip;
	}

	public void Play () {
		source.volume = volume * (1 + Random.Range(-randomVolume / 2f, randomVolume / 2f));
		source.pitch = pitch * (1 + Random.Range(-randomPitch / 2f, randomPitch / 2f));;
		source.Play ();
	}
}

public class AudioManager : MonoBehaviour {

	public static AudioManager instance;

	[SerializeField]			// Peut être changer dans inspector mais pas dans le script
	Sound[] sounds;

	void Awake () {
		if (instance != null) {
			Debug.LogError ("Plus qu'un AudioManager dans la scène.");
		} else
		instance = this;
	}

	void Start () {

		for (int i = 0; i < sounds.Length; i++) {
			GameObject _go = new GameObject ("Sound_" + i + "_" + sounds [i].name);
			sounds [i].SetSource (_go.AddComponent <AudioSource> ());
		}
	}

	public void PlaySound (string _name) {
		for (int i = 0; i < sounds.Length; i++) {
			if (sounds [i].name == _name) {
				sounds [i].Play ();
				return;									// Pour sortir de la loop
			}
		}

		// Si jamais le son est pas relié comme il faut
		Debug.LogWarning ("AudioManager: Le son n'a pas été trouvé dans la liste: " + _name);
	}
}
