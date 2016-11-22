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
	
	// Update is called once per frame
	void Update () {
	
	}
}
