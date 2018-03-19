using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatePlayerFunctions {

	private int classSelection;
	private string[] classSelectionNames = new string[] {"Warrior", "Mage", "Ranger"};


	public void DisplayClassSelections()
	{
		//Creates a grid that hold buttons which you select to pick a class. rect = size of buttons and placement, classSelection is the id of the selected class in the array, 
		//classSelectionNames is the array of names that is uses, 2 is th enumber of buttons wide the grid is
		classSelection = GUI.SelectionGrid(new Rect(50, 50, 250, 300), classSelection, classSelectionNames, 2);
		GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
	}

	public void DisplayFinalSetup()
	{
		
	}

	private string FindClassDescription(int selectedClass)
	{
		//if statements that will find and return the selected class desription
		if (selectedClass == 0)
		{
			BaseCharacter baseCharacter = new BaseWarriorClass();
			return baseCharacter.CharcaterClassDescription;
		}
		else if (selectedClass == 1)
		{
			BaseCharacter baseCharacter = new BaseMageClass();
			return baseCharacter.CharcaterClassDescription;
		}
		else if (selectedClass == 2)
		{
			BaseCharacter baseCharacter = new BaseRangerClass();
			return baseCharacter.CharcaterClassDescription;
		}

		return "";
	}
}
