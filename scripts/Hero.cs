using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class Hero : MonoBehaviour
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

	public void SetHp(int newHp)
	{
		if (newHp >= 0)
		{
			_hp = newHp;
		}
	}

	public void AddHp(int newHp)
	{
		if (newHp > 0)
		{
			_hp += newHp;
		}
	}

	public void RemoveHp(int newHp)
	{
		if (newHp > 0)
		{
			_hp -= newHp;
		}
	}
	
	public void SetAttack(int newAttack)
	{
		if (newAttack >= 0)
		{
			_attack = newAttack;
		}
	}

	public void AddAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			_attack += newAttack;
		}
	}

	public void RemoveAttack(int newAttack)
	{
		if (newAttack > 0)
		{
			_attack -= newAttack;
		}
	}
	
	public void SetMana(int newMana)
	{
		if (newMana >= 0)
		{
			_mana = newMana;
		}
	}

	public void AddMana(int newMana)
	{
		if (newMana > 0)
		{
			_mana += newMana;
		}
	}

	public void RemoveMana(int newMana)
	{
		if (newMana > 0)
		{
			_mana -= newMana;
		}
	}

	public void SetMaxMana(int newMaxMana)
	{
		if (newMaxMana >= 0 && newMaxMana < _maxMaxMana)
		{
			_maxMana = newMaxMana;
		}
	}

	public void AddMaxMana(int newMaxMana)
	{
		if (newMaxMana > 0)
		{
			_maxMana += newMaxMana;
		}
	}

	public void RemoveMaxMana(int newMaxMana)
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
