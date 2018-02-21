using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem {

	public enum WeaponTypes
	{
		SWORD,
		AXE,
		STAFF,
		BOW
	}

	private WeaponTypes weaponType;

	public WeaponTypes WeaponType
	{
		get {return weaponType;}
		set {WeaponType = value;}
	}
}
