using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject); //Don't destory the object the transform is attached to
	}

	public static string PlayerName{get;set;}
	public static BaseCharacter PlayerClass{get;set;}
	public static int PlayerLevel{get;set;}
	public static int Defence{get;set;}
	public static float Speed{get;set;}
	public static int Luck{get;set;}
	public static int CurrentXP{get;set;}
	public static int RequiredXP{get;set;}


}
