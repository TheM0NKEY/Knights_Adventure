using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEquipment : BaseStatItem {

	public enum EquipmentTypes
	{
		HELMET,
		CHESTPIECE,
		GLOVE,
		LEG,
		BOOT,
		CLOAK,
		RING,
		SHIELD
	}

	private EquipmentTypes equipmentType;
	private int spellEffectID;


	public EquipmentTypes EquipmentType
	{
		get {return equipmentType;}
		set {equipmentType = value;}
	}
	public int SpellEffectID
	{
		get {return spellEffectID;}
		set {spellEffectID = value;}
	}
}
