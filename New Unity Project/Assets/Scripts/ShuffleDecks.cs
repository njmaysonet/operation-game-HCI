using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShuffleDecks : MonoBehaviour {

    List<int> cards;

    public void Shuffle()
    {
        if (cards == null)
        {
            cards = new List<int>();
        }
        else
        {
            cards.Clear();
        }

        for(int i = 0; i < 12; i++)//To  be called by both Docter deck and Specialist Deck individually
        {
            cards.Add(i);
        }
    }
    void Start()
    {
        Shuffle();
    }
}
