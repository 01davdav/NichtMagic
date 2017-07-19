using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Board{
        
        public GameObject[] BoardCards = new GameObject[10];
        private Control C;
        private Player P;
        private Board B;

        public void Start()
        {
                C = Camera.main.GetComponent<Control>();
                P = Camera.main.GetComponent<Main>().MPlayer;
                B = Camera.main.GetComponent<Main>().MBoard;
        }
        
        public void PlayCard(GameObject card, int c)
        {
                if (BoardCards[BoardCards.Length-2] == null)
                {
                        card.GetComponent<Card>().Exit();
                        int positionOfCardInHand = System.Array.IndexOf(P.Hand, card);
                        int i = BoardCardLength();

                        Debug.Log(i);
                        C.MoveToBoard(card, c);
                        Debug.Log(BoardCards[8]);
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
