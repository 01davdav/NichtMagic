using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Player MPlayer = new Player();
    public Board MBoard = new Board();
    public Hero MHero = new Hero(20, 1, 5);
    public Turns MTurns = new Turns();
}
