using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardSwitcher : MonoBehaviour {
	public GameObject cardButton;
	public GameObject bodyPartContainer;
	public GameObject specialistButton;
	public GameCore gCore;
	//DOCTOR SPRITES
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
	//SPECIALIST SPRITES
	public Sprite appleSpecial;
	public Sprite heartSpecial;
	public Sprite wrenchSpecial;
	public Sprite butterflySpecial;
	public Sprite ribSpecial;
	public Sprite waterSpecial;
	public Sprite fBoneSpecial;
	public Sprite horseSpecial;
	public Sprite pencilSpecial;
	public Sprite wBoneSpecial;
	public Sprite breadSpecial;
	public Sprite iceCreamSpecial;
	//private variables
	private CardStruct currentCard;
	private BodyPartsScript bodyPartControl;
	private ArrayList currentPlayerCards;
	bool needNewBodyPartActive = false;
	bool needBodyPartDisabled = false;

	/*In this script, we will call functions from GameCore and
	 * from BodyPartsScript in order to switch the current
	 * Doctor Card image to the first card in the 'draw pile'
	 * which is stored as an ArrayList of CardStructs.
	 * 
	 * First we find GameCore in run time using GameObject.Find()
	 * and then ask the core to instantiate the cards. At this point
	 * we now have an active draw pile of cards. By getting the top
	 * of the draw pile, we can display that card's sprite by setting
	 * the card button's image component's sprite value to the return
	 * value of the GetSprite switch which takes the current card's
	 * ID as a parameter.
	 * 
	 * TODO Implement similar logic for switching the Specialist cards
	 * */
	void Start () {
		gCore = GameObject.Find ("GameCore").GetComponent<GameCore> ();
		gCore.MakeDoctorCards ();
		bodyPartControl = bodyPartContainer.GetComponent<BodyPartsScript> ();

		if (gCore != null) {
			Debug.Log ("gCore exists! Good! | CardSwitcher.cs");
			currentCard = gCore.GetCurrentCard ();
			cardButton.GetComponent<Image> ().sprite = GetSprite (currentCard.cardID);
			bodyPartControl.SetBodyPartActive (currentCard.cardID);
			needNewBodyPartActive = true;
		} else {
			Debug.Log ("gCore is null | CardSwitcher.cs");
		}
	}

	void Update()
	{
		if (needNewBodyPartActive) {
			bodyPartControl.SetBodyPartActive (currentCard.cardID);
			needNewBodyPartActive = false;
		} else if(needBodyPartDisabled){
			//disable body part
			//get new card
		}
	}

	//Switch Statment to correlate cardID with Sprite to be displayed
	private Sprite GetSprite(int cardID)
	{
		switch (cardID) 
		{
		case 0:
			return appleSprite;
		case 1:
			return heartSprite;
		case 2:
			return wrenchSprite;
		case 3:
			return butterflySprite;
		case 4:
			return ribSprite;
		case 5:
			return waterSprite;
		case 6:
			return fBoneSprite;
		case 7:
			return horseSprite;
		case 8:
			return pencilSprite;
		case 9:
			return wBoneSprite;
		case 10:
			return breadSprite;
		case 11:
			return iceCreamSprite;
		default:
			Debug.Log ("Switch statement, default entered. Shouldn't happen. | CardSwitcher.cs");
			return appleSprite;
		}
	}
}
