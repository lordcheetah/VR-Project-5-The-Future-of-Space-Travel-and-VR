using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonInfo : MonoBehaviour {

	private int index = 0;
	public Text uiText;

	void Start()
	{
		index = 0;
	}

	public void ShowNextInfo()
	{
		index++;
		if (index > 3)
			index = 0;
		
		switch (index) {
		case 0:
			uiText.text = "";
			break;
		case 1:
			uiText.text = "Experts can guide astronauts on ISS through complicated procedures by watching astronauts' actions and overlay guidance, diagrams, and other info";
			break;
		case 2:
			uiText.text = "Astronauts practiced appendicitis diagnoses and testing during an underwater expedition NASA Extreme Environment Mission Operations 21 (NEEMO) and on the Vomet Comet (an airplane for experiencing zero-g)";
			break;
		case 3:
			uiText.text = "Time for the procedure was reduced from 4 hours to 1 hour";
			break;
		}

		Debug.Log ("Pressed " + index.ToString());
	}
}
