using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewKey : MonoBehaviour {

	private BaseKey newKey;

	//TODO Create array of strings to be used for weapon info
	//TODO Read a JSON or XML File of weapons
	//private string[] keyNames = new String[x]; //Test code for creating the array

	public void CreateKey()
	{
		newKey = new BaseKey();

		//Name
		newKey.ItemName = "Test Key Name";
		//newKey.ItemName = keyNames[x]

		//Description
		newKey.ItemDescription = "This is a new Key";

		//ID
		newKey.ItemID = Random.Range(301,401);

		//ItemType
		newKey.ItemType = BaseItem.ItemTypes.KEY;

		//Effect ID
		newKey.EffectID = Random.Range(1,20);

	}
}
