using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonInfo : MonoBehaviour
{

	private int index = 0;
	private Material defaultMaterial;
	public Text uiText;
	public Material lightUpMaterial;

	void Start()
	{
		string buttonName = gameObject.name;

		index = 0;

		switch (buttonName)
		{
		case "Button Project Sidekick":
			uiText.text = "Project Sidekick";
			break;

		case "Button OnSight":
			uiText.text = "OnSight";
			break;

		case "Button Protospace":
			uiText.text = "Protospace";
			break;

		case "Button Public Virtual Exploration":
			uiText.text = "Public Virtual Exploration";
			break;

		case "Button Astronaut Sanity":
			uiText.text = "Astronaut Sanity";
			break;

		}

		defaultMaterial = this.GetComponent<MeshRenderer> ().material; //Save our initial material as the default
	}

	public void ShowNextInfo()
	{
		string buttonName = gameObject.name;
		index++;

		switch (buttonName)
		{
		case "Button Project Sidekick":
			if (index > 4)
				index = 0;
			
			switch (index) {
			case 0:
				uiText.text = "Project Sidekick";
				break;
			case 1:
				uiText.text = "Experts can guide astronauts on the International Space Station through complicated procedures by watching astronauts' actions and overlay guidance, diagrams, and other info";
				break;
			case 2:
				uiText.text = "Astronauts practiced appendicitis diagnoses and testing during an underwater expedition (NASA Extreme Environment Mission Operations 21 (NEEMO)) and on the Vomet Comet (an airplane for experiencing zero-g)";
				break;
			case 3:
				uiText.text = "Project Sidekick reduced the time for the appendicitis was reduced from 4 hours to 1 hour";
				break;
			case 4:
				uiText.text = "ISS astronauts also used it to play Space Invaders";
				break;
			}
			break;

		case "Button OnSight":
			if (index > 6)
				index = 0;

			switch (index) {
			case 0:
				uiText.text = "OnSight";
				break;
			case 1:
				uiText.text = "Onsight provides a virtual reconstruction of the surface of Mars using Microsoft Hololens";
				break;
			case 2:
				uiText.text = "Geologists, many from outside Martian geology, felt OnSight was more accurate than the 2D images they usually work with";
				break;
			case 3:
				uiText.text = "They realized they could run up a hill to get better spatial awarness";
				break;
			case 4:
				uiText.text = "They were twice more accurate at determining distances";
				break;
			case 5:
				uiText.text = "They were three times more accurate at determining specific angles";
				break;
			case 6:
				uiText.text = "The public can get a tour by a holographic Buzz Aldrin at the Kennedy Space Center";
				break;
			}
			break;

		case "Button Protospace":
			if (index > 4)
				index = 0;

			switch (index) {
			case 0:
				uiText.text = "Protospace";
				break;
			case 1:
				uiText.text = "Engineers can explore detailed models of spacecraft and machinery as they're designed";
				break;
			case 2:
				uiText.text = "It will allow for a group of mechanical engineers to collaboratively visualize a design in its true scale";
				break;
			case 3:
				uiText.text = "Engineers can see how parts of the model fit together better than 2D modelling";
				break;
			case 4:
				uiText.text = "Engineers can even practice tricky installation";
				break;
			}
			break;

		case "Button Public Virtual Exploration":
			if (index > 4)
				index = 0;

			switch (index) {
			case 0:
				uiText.text = "Public Virtual Exploration";
				break;
			case 1:
				uiText.text = "Data gathered by orbiters or probes can be used to explore virtually";
				break;
			case 2:
				uiText.text = "VR explorers might be able to guide rovers or astronauts to interesting places";
				break;
			case 3:
				uiText.text = "Everyone could help explore together not just the Jet Propulsion Laboratory and NASA";
				break;
			}
			break;

		case "Button Astronaut Sanity":
			if (index > 6)
				index = 0;

			switch (index) {
			case 0:
				uiText.text = "Astronaut Sanity";
				break;
			case 1:
				uiText.text = "This is a simulation of a lovely seaside town in the UK, and though it's computer-generated, users can navigate through it and explore";
				break;
			case 2:
				uiText.text = "";
				PlayMovie();
				break;
			case 3:
				uiText.text = "Seeing sunlight, trees, and blue sky contributes to mental health";
				break;
			case 4:
				uiText.text = "Former astronaut Jay Buckey is testing if this VR scene reduces stress levels and improve mood of people stationed at Alert, Canada in the Artic";
				break;
			case 5:
				uiText.text = "\"People who live in this Alert station, they do well but it's dark all the time and it's very cold outside,\" says Buckey. \"So it's a small group of people living in a confined space all the time. It's not like you can go out for a walk in the woods.\"";
				break;
			case 6:
				uiText.text = "Eventually, this will be tested on astronauts living in the International Space Station";
				break;
			}
			break;

		}

		Debug.Log ("Pressed " + buttonName.ToString() + " " + index.ToString());
	}

	public void PlayMovie()
	{
		Handheld.PlayFullScreenMovie ("AstronautSanity.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);

		Debug.Log ("Pressed");
	}

	public void gazeLightUp()
	{
		this.GetComponent<MeshRenderer>().material = lightUpMaterial; //Assign the hover material
	}

	public void aestheticReset()
	{
		this.GetComponent<MeshRenderer>().material = defaultMaterial; //Revert to the default material
	}
}
