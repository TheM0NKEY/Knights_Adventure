using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharacter 
{
	public BaseMageClass()
	{
		CharacterClassName = "Mage";
		CharcaterClassDescription = "Relies on powerful spells to take down enemies";
		Defence = 1;
		Speed = 10.0f;
	}
}
