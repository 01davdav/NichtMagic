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
	private int shield;
	
	public Card(String newName, int newManacosts, int newAttack, int newLife, int newShield)
	{
		setName(newName);
		setManacosts(newManacosts);
		setAttack(newAttack);
		setLife(newLife);
		setShield(newShield);
	}

	public void setName(String newName)
	{
		name = newName;
	}

	public void setManacosts(int newManacosts)
	{
		manacosts = newManacosts;
	}

	public void setAttack(int newAttack)
	{
		attack = newAttack;
	}

	public void setLife(int newLife)
	{
		life = newLife;
	}

	public void setShield(int newShield)
	{
		shield = newShield;
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

	public int getShield()
	{
		return shield;
	}
	
	// Use this for initialization
	void Start () 
	{
		
	}
}
