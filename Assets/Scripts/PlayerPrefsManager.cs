﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{
	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty_key";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume (float volume)
	{
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);

		} else {
			Debug.LogError ("Master volume out of range.");
		}
	}

	public static float GetMasterVolume ()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void SetDifficulty (float difficulty)
	{
		if (difficulty >= 1f && difficulty <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);

		} else {
			Debug.LogError ("Difficulty out of range" + difficulty.ToString ());
		}
	}

	public static float GetDifficulty ()
	{
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}

	public static void UnlockLevel (int level)
	{
		if (level <= SceneManager.GetActiveScene ().buildIndex - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1);

		} else {
			Debug.LogError ("Level does not exist.");
		}
	}

	public static bool IsLevelUnlocked (int level)
	{
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);

		if (level <= SceneManager.GetActiveScene ().buildIndex - 1) {
			return isLevelUnlocked;

		} else {
			Debug.LogError ("Trying to query level not in build error.");
			return false;
		}
	}
}
