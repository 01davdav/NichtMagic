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
		if (newHp > 0)
		{
			hp = newHp;
		}
	}

	public void addHp(int newHp)
	{
		if (newHp > 0)
		{
			hp += newHp;
		}
	}

	public void removeHp(int newHp)
	{
		if (newHp > 0)
		{
			hp -= newHp;
		}
	}
	
	public void setAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			attack = newAttack;
		}
	}

	public void addAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			attack += newAttack;
		}
	}

	public void removeAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			attack -= newAttack;
		}
	}
	
	public void setMana(int newMana)
	{
		if (newMana > 0)
		{
			mana = newMana;
		}
	}

	public void addMana(int newMana)
	{
		if (newMana > 0)
		{
			mana += newMana;
		}
	}

	public void removeMana(int newMana)
	{
		if (newMana > 0)
		{
			mana -= newMana;
		}
	}

	public void setMaxMana(int newMaxmana)
	{
		if (newMaxmana > 0 && newMaxmana < maxMaxMana)
		{
			maxMana = newMaxmana;
		}
	}

	public void addMaxMana(int newMaxmana)
	{
		if (newMaxmana > 0)
		{
			maxMana += newMaxmana;
		}
	}

	public void removeMaxMana(int newMaxmana)
	{
		if (newMaxmana > 0)
		{
			maxMana -= newMaxmana;
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
