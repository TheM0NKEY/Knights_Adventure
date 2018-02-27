using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private bool isRangerClass;

	//Player Name
	private string playerName = "Enter Charcter Name";


	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		playerName = GUILayout.TextField(playerName,20);

		isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
		isRangerClass = GUILayout.Toggle(isRangerClass, "Ranger Class");

		if(GUILayout.Button("Create"))
		{
			if(isMageClass)
			{
				newPlayer.PlayerClass = new BaseMageClass();
			}
			else if(isWarriorClass)
			{
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			else if(isRangerClass)
			{
				newPlayer.PlayerClass = new BaseRangerClass();
			}

			//Sets the player level on character creation
			newPlayer.PlayerLevel = 1;

			//Set Default Stats
			newPlayer.Defence = newPlayer.PlayerClass.Defence;
			newPlayer.Speed = newPlayer.PlayerClass.Speed;
			newPlayer.Luck = newPlayer.PlayerClass.Luck;

			//Set PlayerName
			newPlayer.PlayerName = playerName;

			//Stores the Data to the 'GameInformation' Object
			StoreNewPlayerInfo();

			Debug.Log("Player: " + playerName + " has been created");
		}
	}

	private void StoreNewPlayerInfo()
	{
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.PlayerClass = newPlayer.PlayerClass;
		GameInformation.Defence = newPlayer.Defence;
		GameInformation.Speed = newPlayer.Speed;
		GameInformation.Luck = newPlayer.Luck;
		GameInformation.CurrentXP = newPlayer.CurrentXP;
		GameInformation.RequiredXP = newPlayer.RequiredXP;
	}
}
