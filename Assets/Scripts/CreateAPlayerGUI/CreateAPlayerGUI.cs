using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAPlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates
	{
		CLASSSELECTION, //Display Class Types and possible Sprites
		FINALSETUP //Add Name and other items
	}

	private CreateAPlayerStates currentState;

		
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
}
