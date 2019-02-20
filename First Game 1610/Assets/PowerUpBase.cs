
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject {

	// Use this for initialization
	public float Value = 10;
	
	void OnEnable ()
	{
		Value = 20;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
