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

        int n = cards.Count;

        while(n>1)//A simple sorting algorithm to shuffle cards
        {
            n--;
            int k = Random.Range(0, n + 1);
            int temp = cards[k];
            cards[k] = cards[n];
            cards[n] = temp;
        }
    }
    void Start()
    {
        Shuffle();
    }
}
