using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour {

	private BaseEquipment newEquipment;

	//TODO Create array of strings to be used for weapon info
	//TODO Read a JSON or XML File of weapons
	//private string[] equipment = new String[x]; //Test code for creating the array

	private void CreateEquipment()
	{
		newEquipment = new BaseEquipment();

		//Name
		newEquipment.ItemName = "TestName";
		//newEquipment.ItemName = equipment[x]

		//Description
		newEquipment.ItemDescription = "This is a desc for equipment";

		//ItemID
		newEquipment.ItemID = Random.Range(101, 201);

		//Stats
		//For now they will be hardcoded but plan to add them to the itemfile that is read
		newEquipment.Defence = 0;
		newEquipment.Speed = 0;
		newEquipment.Luck = 0;

		//Spell Effect - Not sure if this will be used later on
		newEquipment.SpellEffectID = Random.Range(1, 20);

		//Equipment Type
		ChooseEquipmentType();

		//ItemType
		newEquipment.ItemType = BaseItem.ItemTypes.EQUIPMENT;
	}

	private void ChooseEquipmentType()
	{
		int temp = Random.Range(1,9);

		switch (temp)
		{
			case 1:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HELMET;
				break;
			case 2:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHESTPIECE;
				break;
			case 3:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.GLOVE;
				break;
			case 4:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEG;
				break;
			case 5:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BOOT;
				break;
			case 6:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CLOAK;
				break;
			case 7:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
				break;
			case 8:
				newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHIELD;
				break;
		}
	}
}
