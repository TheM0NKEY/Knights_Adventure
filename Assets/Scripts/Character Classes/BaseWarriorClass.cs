using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacter 
{
	public BaseWarriorClass()
	{
		CharacterClassName = "Warrior";
		CharcaterClassDescription = "Relies on Melee attacks to take down enemies";
		Defence = 1;
		Speed = 7.0f;
	}
		
}
