using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp {

	public void LevelUpCharacter()
	{
		//This function will be called when the player levels up
		//Can be used to give the player an item, increased stats, unlock areas, new moves etc.
		//Determine the next amount of required xp
		DetermineRequiredXP();

	}

	private void DetermineRequiredXP()
	{
		GameInformation.RequiredXP += 50; //Basic increase in required xp for the next level.
	}
}
