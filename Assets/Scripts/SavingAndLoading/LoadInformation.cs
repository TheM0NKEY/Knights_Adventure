using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

	public static void LoadAllInformation()
	{
		GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
		GameInformation.Defence = PlayerPrefs.GetInt("DEFENCE");
		GameInformation.Speed = PlayerPrefs.GetFloat("SPEED");
		GameInformation.Luck = PlayerPrefs.GetInt("LUCK");
	}
}
