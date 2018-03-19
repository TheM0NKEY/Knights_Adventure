using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAPlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates
	{
		CLASSSELECTION, //Display Class Types and possible Sprites
		FINALSETUP //Add Name and other items
	}

	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
	public static CreateAPlayerStates currentState;

		
	// Use this for initialization
	void Start () 
	{
		currentState = CreateAPlayerStates.CLASSSELECTION;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(currentState)
		{
			case(CreateAPlayerStates.CLASSSELECTION):
				break;

			case(CreateAPlayerStates.FINALSETUP):
				break;
		}
	}

	void OnGUI()
	{
		//Temporary basic GUI to test that functions work. TODO: Create proper scene with desired layout and textures

		if (currentState == CreateAPlayerStates.CLASSSELECTION)
		{
			//Display class selection function goes here
			displayFunctions.DisplayClassSelections();

		}
		if (currentState == CreateAPlayerStates.FINALSETUP)
		{
			//Display Final Setup Functions goes here
			displayFunctions.DisplayFinalSetup();
		}
	}
}
