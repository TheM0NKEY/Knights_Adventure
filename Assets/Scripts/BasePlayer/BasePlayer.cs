using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

	private string playerName;
	private int playerLevel;
	private BaseCharacter playerClass;
	private int defence;
	private float speed;
	private int luck;


	public string PlayerName
	{
		get {return playerName;}
		set {playerName = value;}
	}
	public int PlayerLevel
	{
		get {return playerLevel;}
		set {playerLevel = value;}
	}
	public BaseCharacter PlayerClass
	{
		get {return playerClass;}
		set {playerClass = value;}
	}
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
