using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

	public bool CanWalk;
	public int Number;
	public string Password;

	// Use this for initialization
	void Start() {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!CanWalk)
		{
			print("True");
		}
		else
		{
			
		}
	}
}
