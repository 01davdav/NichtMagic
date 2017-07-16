using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;

public class Hero : MonoBehaviour
{

	private int hp;
	private int attack;
	private int mana;
	
	public Hero(int newHp, int newAttack, int newMana)
	{
		setHp(newHp);
		setAttack(newAttack);
		setMana(newMana);
	}

	void setHp(int newHp)
	{
		hp = newHp;
	}
	
	void setAttack(int newAttack)
	{
		attack = newAttack;
	}
	
	void setMana(int newMana)
	{
		mana = newMana;
	}

	int getHp()
	{
		return hp;
	}

	int getAttack()
	{
		return attack;
	}

	int getMana()
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
