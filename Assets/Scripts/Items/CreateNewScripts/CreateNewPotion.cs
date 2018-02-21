using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;

	//TODO Create array of strings to be used for weapon info
	//TODO Read a JSON or XML File of weapons
	//private string[] potionNames = new String[x]; //Test code for creating the array

	public void CreatePotion()
	{
		newPotion = new BasePotion();

		//Name
		newPotion.ItemName = "Test Potion Name";
		//newPotion.ItemName = potionNames[x]

		//Description
		newPotion.ItemDescription = "This is a potion description";

		//ID
		newPotion.ItemID = Random.Range(201, 301);

		//Potion Type
		ChoosePotionType();

		//Spell Effect
		newPotion.SpellEffectID = Random.Range(1,20); //This will need to be set based on the type of potion at a later date TODO

	}

	private void ChoosePotionType()
	{
		int temp = Random.Range(1, 6);

		switch (temp)
		{
			case 1:
				newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
				break;
			case 2:
				newPotion.PotionType = BasePotion.PotionTypes.DEFENCE;
				break;
			case 3:
				newPotion.PotionType = BasePotion.PotionTypes.SPEED;
				break;
			case 4:
				newPotion.PotionType = BasePotion.PotionTypes.LUCK;
				break;
			case 5:
				newPotion.PotionType = BasePotion.PotionTypes.XP;
				break;
		}
	}
}
