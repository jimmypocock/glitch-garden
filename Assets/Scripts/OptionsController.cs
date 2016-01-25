using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
	public Slider volumeSlider;
	public Slider difficultySlider;

	private SoundManager soundManager;

	void Start ()
	{
		soundManager = GameObject.FindObjectOfType<SoundManager> ();

		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}

	void Update ()
	{
		soundManager.SetVolume (volumeSlider.value);

	}

	public void SaveAndExit ()
	{
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);
		SceneManager.LoadScene ("01a Start");
	}

	public void SetToDefault ()
	{
		volumeSlider.value = 0.75f;
		difficultySlider.value = 1f;
	}
	
}
