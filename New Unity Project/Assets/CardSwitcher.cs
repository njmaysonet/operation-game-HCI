using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardSwitcher : MonoBehaviour {
	public Button cardButton;
	public GameCore gCore;
	public Sprite appleSprite; //1
	public Sprite heartSprite; //2
	public Sprite wrenchSprite; //3
	public Sprite butterflySprite; //4
	public Sprite ribSprite; //5
	public Sprite waterSprite; //6
	public Sprite fBoneSprite; //7
	public Sprite horseSprite; //8
	public Sprite pencilSprite; //9
	public Sprite wBoneSprite; //10
	public Sprite breadSprite; //11
	public Sprite iceCreamSprite; //12
	private CardStruct currentCard;

	// Use this for initialization
	void Start () {
		gCore = GameObject.Find ("GameCore").GetComponent<GameCore> ();
		currentCard = gCore.GetCurrentCard ();
	}

	//Switch Statment to correlate cardID with Sprite to be displayed
	private Sprite GetSprite(int cardID)
	{
		switch (cardID) 
		{
		case 0:
			return appleSprite;
			break;
		case 1:
			return heartSprite;
			break;
		case 2:
			return wrenchSprite;
			break;
		case 3:
			return butterflySprite;
			break;
		case 4:
			return ribSprite;
			break;
		case 5:
			return waterSprite;
			break;
		case 6:
			return fBoneSprite;
			break;
		case 7:
			return horseSprite;
			break;
		case 8:
			return pencilSprite;
			break;
		case 9:
			return wBoneSprite;
			break;
		case 10:
			return breadSprite;
			break;
		case 11:
			return iceCreamSprite;
			break;
		}
	}
}
