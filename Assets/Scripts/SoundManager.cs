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

	public void SetVolume (float volume)
	{
		audioSource.volume = volume;
	}

}
