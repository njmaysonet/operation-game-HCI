using UnityEngine;
using System.Collections;

public class PlayerStruct : MonoBehaviour {

	private int playerID;
    private bool playerTurn;
    private string playerName;
	public ArrayList cardList;

	void Awake()
	{
		playerID = -1;
		playerTurn = false;
		playerName = "";
		cardList = new ArrayList ();
		DontDestroyOnLoad (this.gameObject);
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
