using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Board{
        
        public GameObject[] BoardCards = new GameObject[9];
        private Control C;
        private Player P;
        private Board B;

        public void Start()
        {
                C = Camera.main.GetComponent<Control>();
                P = Camera.main.GetComponent<Main>().MPlayer;
                B = Camera.main.GetComponent<Main>().MBoard;
        }
        
        public void PlayCard(GameObject card)
        {
                card.GetComponent<Card>().Exit();
                int positionOfCardInHand = System.Array.IndexOf(P.Hand, card);
                int i = BoardCardLength();
                int c = 0; //soll später die position sein wo es platziert werden soll, nur für testzwecke auf 3 gesetzt
                
                Debug.Log(i);
                if (i == 0)
                {
                        C.MoveCardToBoard(card, 5, 0, false, positionOfCardInHand); 
                }
                else if (i == 1)
                {
                        if (c == 0)
                        {
                                C.MoveCardToBoard(card, 4.5f, 0, true, positionOfCardInHand);
                                C.MoveCardToBoard(B.BoardCards[1], 5.5f, 1, false);
                        }
                        else
                        {
                                C.MoveCardToBoard(card, 5.5f, 1, false, positionOfCardInHand);
                                C.MoveCardToBoard(B.BoardCards[0], 4.5f, 0, false);
                                
                        }
                }
                else if (i == 2)
                {
                        if (c == 0)
                        {
                                C.MoveCardToBoard(card, 4f, 0, false, positionOfCardInHand);
                                C.MoveCardToBoard(B.BoardCards[1], 5f, 1, false);
                                C.MoveCardToBoard(B.BoardCards[2], 6f, 2, false);
                        }
                        else if (c == 1)
                        {
                                C.MoveCardToBoard(card, 5f, 1, true, positionOfCardInHand);
                                C.MoveCardToBoard(B.BoardCards[0], 4f, 0, false);
                                C.MoveCardToBoard(B.BoardCards[1], 6f, 1, false);
                        }
                        else
                        {
                                C.MoveCardToBoard(card, 6f, 2, false, positionOfCardInHand);
                                C.MoveCardToBoard(B.BoardCards[0], 4f, 0, false);
                                C.MoveCardToBoard(B.BoardCards[1], 5f, 1, false);
                        }
                }
        }

        public int BoardCardLength()
        {
                int counter = 0;
                for (int i = 0; i < B.BoardCards.Length; i++)
                {
                        if (B.BoardCards[i] != null)
                        {
                                counter++;
                        }
                }
                return counter;
        }
}
