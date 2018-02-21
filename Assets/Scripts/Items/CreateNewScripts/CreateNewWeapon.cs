using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	//TODO Create array of strings to be used for weapon info
	//TODO Read a JSON or XML File of weapons
	//private string[] weaponNames = new String[x]; //Test code for creating the array

	public void CreateWeapon()
	{
		newWeapon = new BaseWeapon();

		//Assign name
		newWeapon.ItemName = "W" + Random.Range(1, 101);
		//newWeapon.ItemName = weaponNames[x]

		//Create description
		newWeapon.ItemDescription = "This is a description";

		//Weapon ID
		newWeapon.ItemID = Random.Range(1,101);

		//Stats
		newWeapon.Defence = 0;
		newWeapon.Speed = 0;
		newWeapon.Luck = 0;

		//Choose Type of weapon
		ChooseWeaponType();

		//Set ItemType
		newWeapon.ItemType = BaseItem.ItemTypes.WEAPON;
	}

	private void ChooseWeaponType()
	{
		int temp = Random.Range(1,5);

		switch (temp)
		{
			case 1:
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
				break;
			case 2:
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.AXE;
				break;
			case 3:
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
				break;
			case 4:
				newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
				break;
		}

	}
}
