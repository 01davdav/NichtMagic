using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	private String name;
	
	public Card(String newName)
	{
		setName(newName);
	}

	void setName(String newName)
	{
		name = newName;
	}
	
	public string getName()
	{
		return name;
	}
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
