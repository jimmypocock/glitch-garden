using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
	static SoundManager instance = null;

	public AudioClip splashSound;
	//	public AudioClip gameClip;
	//	public AudioClip endClip;

	private AudioSource music;

	void Start ()
	{
		if (instance != null && instance != this) {
			Destroy (gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);

			music = GetComponent<AudioSource> ();
			music.clip = splashSound;
			music.loop = true;
			music.Play ();
		}

	}

	void OnLevelWasLoaded (int level)
	{
		music.Stop ();

		if (level == 0) {
			music.clip = splashSound;
		} else {
			music.clip = splashSound;
		}
		music.loop = true;

		music.Play ();
	}

}
