using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngineInternal.Input;

public class Hero
{

	private static int _hp;
	private static int _attack;
	private static int _mana;
	private static int _maxMana;
	private static int _maxMaxMana = 15;
	private static Boolean _mayattack;
	private static string  _name;
	
	public Hero(int newHp, int newAttack, int newMaxMana)
	{
		SetHp(newHp);
		SetAttack(newAttack);
		SetMana(newMaxMana);
	}

	public static void SetName(string newName)
	{
		if (!String.IsNullOrEmpty(newName))
		{
			_name = newName;
		}
	}

	public static void SetMayAttack(Boolean newMayAttack)
	{
		_mayattack = newMayAttack;
	}
	
	public static void SetHp(int newHp) //set hp of hero
	{
		if (newHp >= 0)
		{
			_hp = newHp;
		}
	}

	public static void AddHp(int newHp) //add hp to hero
	{
		if (newHp > 0)
		{
			_hp += newHp;
		}
	}

	public static void RemoveHp(int newHp) //subtract hp from hero
	{
		if (newHp > 0)
		{
			_hp -= newHp;
		}
	}
	
	public static void SetAttack(int newAttack) //set attack of hero
	{
		if (newAttack >= 0)
		{
			_attack = newAttack;
		}
	}

	public static void AddAttack(int newAttack) //add attack to hero
	{
		if (newAttack > 0)
		{
			_attack += newAttack;
		}
	}

	public static void RemoveAttack(int newAttack) //subtract attack from hero
	{
		if (newAttack > 0)
		{
			_attack -= newAttack;
		}
	}
	
	public static void SetMana(int newMana) //set current mana of hero(start of turn)
	{
		if (newMana >= 0)
		{
			_mana = newMana;
		}
	}

	public static void AddMana(int newMana) //add to current mana of hero
	{
		if (newMana > 0)
		{
			_mana += newMana;
		}
	}

	public static void RemoveMana(int newMana) //subtract from current mana of hero (playing a card)
	{
		if (newMana > 0)
		{
			_mana -= newMana;
		}
	}

	public static void SetMaxMana(int newMaxMana) //set maximum of mana of hero (add 1 each turn)
	{
		if (newMaxMana >= 0 && newMaxMana < _maxMaxMana)
		{
			_maxMana = newMaxMana;
		}
	}

	public static void AddMaxMana(int newMaxMana) //add to maximum mana of hero
	{
		if (newMaxMana > 0)
		{
			_maxMana += newMaxMana;
		}
	}

	public static void RemoveMaxMana(int newMaxMana) //subtract from maximum mana of hero
	{
		if (newMaxMana > 0)
		{
			_maxMana -= newMaxMana;
		}
	}

	public static int GetMaxMana()
	{
		return _maxMana;
	}
	
	public static int GetHp()
	{
		return _hp;
	}

	public static int GetAttack()
	{
		return _attack;
	}

	public static int GetMana()
	{
		return _mana;
	}
}
