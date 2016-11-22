using UnityEngine;
using System.Collections;
using System;

public class CardStruct : MonoBehaviour {

    SpriteRenderer spriteRenderer;
    public Sprite[] DocterFace;//Array of Sprites to contain the Docter Deck
    public Sprite[] SpecialistFace;//Array of Sprites to contian Specialist Deck to keep track of the individial cards
    public Sprite[] CardFaces;//An array to keep track of the positions of every card. First 12 will be docter, next 12 will be used for Specialist
    //We don't have to use this method but I think it would work well
    //It would be for shuffling cards with the cardfaces array and then obtaining the index of its location and using that index for the next array of Docter/Specialist

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

        //Maru Code
        //spriteRenderer = GetComponent<SpriteRenderer>();
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
		
}
