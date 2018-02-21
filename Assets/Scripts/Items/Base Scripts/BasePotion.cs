using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseStatItem {

	public enum PotionTypes
	{
		HEALTH,
		DEFENCE,
		SPEED,
		LUCK,
		XP
	}

	private PotionTypes potionType;
	private int spellEffectID;

	public PotionTypes PotionType
	{
		get {return potionType;}
		set {potionType = value;}
	}
	public int SpellEffectID
	{
		get {return spellEffectID;}
		set {spellEffectID = value;}
	}
}
