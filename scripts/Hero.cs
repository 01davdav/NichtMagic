using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class Hero
{

	private int _hp;
	private int _attack;
	private int _mana;
	private int _maxMana;
	private int _maxMaxMana = 15;
	
	public Hero(int newHp, int newAttack, int newMaxMana)
	{
		SetHp(newHp);
		SetAttack(newAttack);
		SetMana(newMaxMana);
	}

	public void SetHp(int newHp) //set hp of hero
	{
		if (newHp >= 0)
		{
			_hp = newHp;
		}
	}

	public void AddHp(int newHp) //add hp to hero
	{
		if (newHp > 0)
		{
			_hp += newHp;
		}
	}

	public void RemoveHp(int newHp) //subtract hp from hero
	{
		if (newHp > 0)
		{
			_hp -= newHp;
		}
	}
	
	public void SetAttack(int newAttack) //set attack of hero
	{
		if (newAttack >= 0)
		{
			_attack = newAttack;
		}
	}

	public void AddAttack(int newAttack) //add attack to hero
	{
		if (newAttack > 0)
		{
			_attack += newAttack;
		}
	}

	public void RemoveAttack(int newAttack) //subtract attack from hero
	{
		if (newAttack > 0)
		{
			_attack -= newAttack;
		}
	}
	
	public void SetMana(int newMana) //set current mana of hero(start of turn)
	{
		if (newMana >= 0)
		{
			_mana = newMana;
		}
	}

	public void AddMana(int newMana) //add to current mana of hero
	{
		if (newMana > 0)
		{
			_mana += newMana;
		}
	}

	public void RemoveMana(int newMana) //subtract from current mana of hero (playing a card)
	{
		if (newMana > 0)
		{
			_mana -= newMana;
		}
	}

	public void SetMaxMana(int newMaxMana) //set maximum of mana of hero (add 1 each turn)
	{
		if (newMaxMana >= 0 && newMaxMana < _maxMaxMana)
		{
			_maxMana = newMaxMana;
		}
	}

	public void AddMaxMana(int newMaxMana) //add to maximum mana of hero
	{
		if (newMaxMana > 0)
		{
			_maxMana += newMaxMana;
		}
	}

	public void RemoveMaxMana(int newMaxMana) //subtract from maximum mana of hero
	{
		if (newMaxMana > 0)
		{
			_maxMana -= newMaxMana;
		}
	}

	public int GetMaxMana()
	{
		return _maxMana;
	}
	
	public int GetHp()
	{
		return _hp;
	}

	public int GetAttack()
	{
		return _attack;
	}

	public int GetMana()
	{
		return _mana;
	}
}
