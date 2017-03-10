using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayMovie : MonoBehaviour {
	
	public void Play()
	{
		Handheld.PlayFullScreenMovie ("AstronautSanity.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);

		Debug.Log ("Pressed");
	}
}
