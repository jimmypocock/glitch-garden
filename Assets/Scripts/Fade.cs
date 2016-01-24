using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fade : MonoBehaviour
{
	public float fadeInTime;

	private Image fadePanel;
	private Color currentColor = Color.black;

	// Use this for initialization
	void Start ()
	{
		fadePanel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.timeSinceLevelLoad < fadeInTime) {
			// how much time we need to constantly change.
			float alphaChange = Time.deltaTime / fadeInTime;	
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;

		} else {
			gameObject.SetActive (false);
		}
	}
}
