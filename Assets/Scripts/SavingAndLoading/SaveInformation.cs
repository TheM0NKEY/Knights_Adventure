using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

	public static void SaveAllInformation()
	{
		PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetInt("PLAYERDEFENCE", GameInformation.Defence);
		PlayerPrefs.SetFloat("PLAYERSPEED", GameInformation.Speed);
		PlayerPrefs.SetInt("PLAYERLUCK", GameInformation.Luck);
	}
}
