using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem {

	private int defence;
	private float speed;
	private int luck;

	public int Defence
	{
		get {return defence;}
		set {defence = value;}
	}
	public float Speed
	{
		get {return speed;}
		set {speed = value;}
	}
	public int Luck
	{
		get {return luck;}
		set {luck = value;}
	}
}
