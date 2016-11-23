using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BodyPartsScript : MonoBehaviour {
	public Button adamsApple;
	public Button brokenHeart;
	public Button wrenchedAnkle;
	public Button bfStomach;
	public Button spareRibs;
	public Button waterKnee;
	public Button funnyBone;
	public Button charlieHorse;
	public Button writersCramp;
	public Button wishBone;
	public Button breadBasket;
	public Button iceCream;
	private Button temp;

	// Use this for initialization
	void Start () {
		adamsApple.interactable = false;
		brokenHeart.interactable = false;
		wrenchedAnkle.interactable = false;
		bfStomach.interactable = false;
		spareRibs.interactable = false;
		waterKnee.interactable = false;
		funnyBone.interactable = false;
		charlieHorse.interactable = false;
		writersCramp.interactable = false;
		wishBone.interactable = false;
		breadBasket.interactable = false;
		iceCream.interactable = false;
	}
	
	public void SetBodyPartActive(int id)
	{
		switch (id) 
		{
		case 0:
			adamsApple.interactable = true;
			break;
		case 1:
			brokenHeart.interactable = true;
			break;
		case 2:
			wrenchedAnkle.interactable = true;
			break;
		case 3:
			bfStomach.interactable = true;
			break;
		case 4:
			spareRibs.interactable = true;
			break;
		case 5:
			waterKnee.interactable = true;
			break;
		case 6:
			funnyBone.interactable = true;
			break;
		case 7:
			charlieHorse.interactable = true;
			break;
		case 8:
			writersCramp.interactable = true;
			break;
		case 9:
			wishBone.interactable = true;
			break;
		case 10:
			breadBasket.interactable = true;
			break;
		case 11:
			iceCream.interactable = true;
			break;
		default:
			Debug.Log ("No button made active. Shouldn't happen");
			break;
		}
	}
}
