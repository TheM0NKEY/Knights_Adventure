using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseExperiance {

	/// <summary>
	/// This holds all functions to give xp to the player
	/// </summary>
	/// <param name="xpToGain">Xp to gain.</param>
	/// <param name="mobLevel">Mob level.</param>

	public static void AddCombatExperience(int xpToGain, int mobLevel)
	{



		if (mobLevel <= (GameInformation.PlayerLevel-2))
		{
			xpToGain = (int)(xpToGain * 0.20);

		}
		else if (mobLevel >= (GameInformation.PlayerLevel+2))
		{
			xpToGain = (int)(xpToGain * 1.2);

		}
		GameInformation.CurrentXP += xpToGain;

		CheckIfPlayerLeveled();
		/*
		Experiance gain:
		Check level of killed mob, 
		if less than playerLevel-2 then mobXP * 0.2
		if greater then playerLevel+2 then mobXP * 1.2
		if less than playerLevel+2 && greater than playerLevel-2 then mobXP
		*/
	}

	private void CheckIfPlayerLeveled()
	{

		bool tempBool = true;
		while (tempBool == true)
		{
			if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
			{
				int temp = GameInformation.CurrentXP - GameInformation.RequiredXP; //Get spare xp 

				GameInformation.PlayerLevel++; //Increase player level by one
				GameInformation.RequiredXP += 50; //Increase the requiredXP amount
				GameInformation.CurrentXP = 0; //Reset CurrentXP to 0

				if (temp > 0)
				{
					GameInformation.CurrentXP += temp; //Add any additional XP gained.
				}
			}
			else
			{
				tempBool = false;
			}
		}
	}

}
