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

	public int getManacosts()
	{
		return manacosts;
	}

	public int getAttack()
	{
		return attack;
	}

	public int getLife()
	{
		return life;
	}
	
	public string getName()
	{
		return name;
	}
	
	// Use this for initialization
	void Start () 
	{
		
	}
}
