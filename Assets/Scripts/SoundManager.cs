using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{

	public AudioClip[] musicChangeArray;

	private AudioSource audioSource;

	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
	}

	void Start ()
	{
		audioSource = GetComponent<AudioSource> ();
		OnLevelWasLoaded (0);
	}

	void OnLevelWasLoaded (int level)
	{
		AudioClip currentLevelMusic = musicChangeArray [level];

		if (currentLevelMusic && currentLevelMusic != audioSource.clip) {
			audioSource.clip = currentLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}




	//	static SoundManager instance = null;
	//
	//	public AudioClip splashSound;
	//	//	public AudioClip gameClip;
	//	//	public AudioClip endClip;
	//
	//	private AudioSource music;
	//
	//	void Start ()
	//	{
	//		if (instance != null && instance != this) {
	//			Destroy (gameObject);
	//		} else {
	//			instance = this;
	//			GameObject.DontDestroyOnLoad (gameObject);
	//
	//			music = GetComponent<AudioSource> ();
	//			music.clip = splashSound;
	//			music.loop = true;
	//			music.Play ();
	//		}
	//
	//	}
	//


}
