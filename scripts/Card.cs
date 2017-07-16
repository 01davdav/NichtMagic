using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	private String name;
	private int manacosts;
	private int attack;
	private int life;

	Card(String newName)
	{
		setName(newName);
	}
	
	Card(String newName, int newManacosts, int newAttack, int newLife)
	{
		setName(newName);
		setManacosts(newManacosts);
		setAttack(newAttack);
		setLife(newLife);
	}

	void setName(String newName)
	{
		name = newName;
	}

	void setManacosts(int newManacosts)
	{
		manacosts = newManacosts;
	}

	void setAttack(int newAttack)
	{
		attack = newAttack;
	}

	void setLife(int newLife)
	{
		life = newLife;
	}

	int getManacosts()
	{
		return manacosts;
	}

	int getAttack()
	{
		return attack;
	}

	int getLife()
	{
		return life;
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
