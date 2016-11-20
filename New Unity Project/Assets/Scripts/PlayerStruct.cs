using UnityEngine;
using System.Collections;

public class PlayerStruct : MonoBehaviour {

	public int playerID;
    public bool playerTurn;
    public string playerName;
	public ArrayList cardList;

	void Awake()
	{
		playerID = -1;
		playerTurn = false;
		playerName = "";
		cardList = new ArrayList ();
		DontDestroyOnLoad (this);
	}

    public void setPlayerName(string name)
    {
        playerName = name;
    }

    public string getPlayerName()
    {
        return playerName;
    }

	public void addCard(CardStruct card)
	{
		cardList.Add(card);
	}

	public void deleteCard(CardStruct card)
	{
		cardList.Remove(card);
	}	
}
