using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

	private BaseCharacter class1 = new BaseWarriorClass();
	private BaseCharacter class2 = new BaseMageClass();
	private BaseCharacter class3 = new BaseRangerClass(); 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{
		GUILayout.Label(class1.CharacterClassName); 
		GUILayout.Label(class1.CharcaterClassDescription);
		GUILayout.Label(class2.CharacterClassName); 
		GUILayout.Label(class2.CharcaterClassDescription);
		GUILayout.Label(class3.CharacterClassName); 
		GUILayout.Label(class3.CharcaterClassDescription);
	}
}
