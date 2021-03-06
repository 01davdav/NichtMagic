﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Board{
        
        public GameObject[] BoardCards;
        private Control C;
        private Player P;
        private Hero H;

        public void Start()
        {
                BoardCards = new GameObject[10];
                C = Camera.main.GetComponent<Control>();
                P = Camera.main.GetComponent<Main>().MPlayer;
                H = Camera.main.GetComponent<Main>().MHero;

        }

        public void PlayCard(GameObject card, int c)
        {

                if(H.GetMana() >= card.GetComponent<Card>().GetManacosts())
                {
                        H.RemoveMana(card.GetComponent<Card>().GetManacosts());
                        C.UpdateMana();
                        if (card.GetComponent<Card>().GetType() == 0)
                        {
                                if (BoardCards[BoardCards.Length - 2] == null)
                                {
                                        int positionOfCardInHand = System.Array.IndexOf(P.Hand, card);
                                        int i = BoardCardLength();

                                        Debug.Log(i);
                                        C.MoveToBoard(card, c);
                                }
                        }

                        if (card.GetComponent<Card>().GetType() == 1)
                        {
                                GameObject thisC = null;
                                for (int i = 0; i < BoardCardLength(); i++)
                                {
                                        if (BoardCards[i].CompareTag("Active"))
                                        {
                                                thisC = BoardCards[i];
                                                break;
                                        }
                                }
                                if (thisC != null)
                                        C.MoveToCard(thisC, card);
                        }
                }
        }

        public int BoardCardLength()
        {
                int counter = 0;
                for (int i = 0; i < BoardCards.Length; i++)
                {
                        if (BoardCards[i] != null)
                        {
                                counter++;
                        }
                }
                return counter;
        }
}
