using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board{
        
        public GameObject[] BoardCards = new GameObject[9];
        private Control C;
        private Player P;

        public void Start()
        {
                C = Camera.main.GetComponent<Control>();
                P = Camera.main.GetComponent<Main>().MPlayer;
        }
        
        public void PlayCard()
        {
                //int i = B.BoardCards.Length;
                if (BoardCards[0] == null)
                {
                        C.MoveCardToBoard(P.Hand[0], 5);
                }

        }
}
