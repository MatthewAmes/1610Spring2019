﻿using UnityEngine;
using UnityEngine.Events;

public class GearEvent : MonoBehaviour
{
    public UnityEvent Event;
	
	private void OnCollisionEnter2D()
    {
        Event.Invoke();
	}
}
