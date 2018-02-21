using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour {

	private string characterClassName;
	private string charcaterClassDescription;
	private int defence; //Defence stat of the charcater
	private float speed;//The speed the charcter moves at
	private int luck;


	//Get and setters 
	public string CharacterClassName
	{
		get {return characterClassName;}
		set {characterClassName = value;}
	}
	public string CharcaterClassDescription
	{
		get {return charcaterClassDescription;}
		set {charcaterClassDescription = value;}
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
