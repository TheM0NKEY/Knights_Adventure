using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRangerClass : BaseCharacter{

	public BaseRangerClass()
	{
		CharacterClassName = "Ranger";
		CharcaterClassDescription = "Relies on long range weaponry to take down enemies";
		Defence = 1;
		Speed = 13.0f;
	}
}
