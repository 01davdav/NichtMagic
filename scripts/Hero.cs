using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class Hero : MonoBehaviour
{

	private int hp;
	private int attack;
	private int mana;
	private int maxMana;
	private int maxMaxMana = 15;
	
	public Hero(int newHp, int newAttack, int newMaxMana)
	{
		setHp(newHp);
		setAttack(newAttack);
		setMana(newMaxMana);
	}

	public void setHp(int newHp)
	{
		hp = newHp;
	}
	
	public void setAttack(int newAttack)
	{
		attack = newAttack;
	}
	
	public void setMana(int newMana)
	{
		mana = newMana;
	}

	public void setMaxMana(int newMaxmana)
	{
		if (maxMana < maxMaxMana)
		{
			maxMana = newMaxmana;
		}
	}

	public int getMaxMana()
	{
		return maxMana;
	}
	
	public int getHp()
	{
		return hp;
	}

	public int getAttack()
	{
		return attack;
	}

	public int getMana()
	{
		return mana;
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
