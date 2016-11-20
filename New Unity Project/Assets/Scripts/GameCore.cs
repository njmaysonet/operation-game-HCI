using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameCore : MonoBehaviour {
    private static int gameTurn;
    public int playerCount;
    public int currentPlayerID;
	public ArrayList playerList;
	public ArrayList shuffleList;
	private CardStruct tempCard;

    
	// Use this for initialization
	void Awake () {
        gameTurn = 0; //first game turn
        currentPlayerID = 0; //first player
        playerCount = 1; //initially set to 1
		playerList = new ArrayList();
		shuffleList = new ArrayList ();
		DontDestroyOnLoad(this.gameObject);

	}

	void Update()
	{
		/*TODO Code for loading the scenes
		 * Load main menu scene
		 * Load player quantity select scene after hitting Start
		 * Load player naming scene after selecting quantity
		 * MUST PRESERVE DATA SCENE TO SCENE
		 * Finally load the game scene
		 */
	}

    //Increments game turn
    void NextTurn()
    {
        gameTurn++;
    }

	void MakeCards()
	{
		//Instantiating the cards
		for (int i = 0; i < 12; i++) {
		//	tempCard = Instantiate (CardStruct);
			tempCard.cardID = i;
			tempCard.SetVisible (false);
			shuffleList.Add (tempCard);
		}
	}

}
