using UnityEngine;
using System.Collections;
using System;

public class CardStruct : MonoBehaviour {
	public int cardID;
	public string cardName;
	public bool isSpecialistCard; //Doctor card if false
	private int[] cardFees = {100,100,100,100,150,150,200,200,200,300,1000,600};
	private Guid unique;
	void Awake()
	{
		cardID = 0;
		cardName = "";
		isSpecialistCard = false;
		unique = Guid.NewGuid ();
		DontDestroyOnLoad (this.gameObject);
	}

	/*returns the amount of points the player gets
	when they succeed in a maze*/
	public int GetPrizeAmount()
	{
		if (isSpecialistCard) {
			return cardFees [cardID] * 2;
		} else {
			return cardFees [cardID];
		}
	}

	public void SetVisible(bool value)
	{
		this.SetVisible = value;
	}
}
