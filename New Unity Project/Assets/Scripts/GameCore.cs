using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameCore : MonoBehaviour {
	/*This class acts as a container for global
	 * variables and data structures. GameObjects
	 * from multiple scenes will call methods
	 * from this class to receive instructions
	 * and relevant data in order to run the game
	 * properly */
    private static int gameTurn;
    public int playerCount;
    public int currentPlayerID;
	public ArrayList playerList;
	public ArrayList doctorCardList;
	public ArrayList specialistCardList;
	private CardStruct tempCard;
	private CardStruct prefabCard;
	private PlayerStruct tempPlayer;
	public PlayerStruct originalPlayer;

    
	/*Sets up the variables in GameCore and
	 * prevents the GameCore GameObject from
	 * being destroyed when loading a new Scene
	 */
	void Awake () {
        gameTurn = 0; //first game turn
        currentPlayerID = 0; //first player
        playerCount = 1; //initially set to 1
		playerList = new ArrayList();
		doctorCardList = new ArrayList ();
		specialistCardList = new ArrayList ();
		DontDestroyOnLoad(this);
	}

	void Update()
	{
		//Nothing needs to be checked every frame yet
	}

    //Increments game turn
    void NextTurn()
    {
        gameTurn++;
    }

	public void SetPlayerCount(int count)
	{
		playerCount = count;
	}
	//must call AFTER SetPlayerCount
	public void CreatePlayers()
	{
		for (int i = 0; i < playerCount; i++) {
			tempPlayer = Instantiate (originalPlayer);
			tempPlayer.playerID = i + 1;
			playerList.Add (tempPlayer);
		}
	}

	//Adaptation of Mauricio's code from ShuffleDeck script
	//Loop to shuffle cards
	public void Shuffle(ArrayList shuffleList)
	{
		if (shuffleList == null)
		{
			Debug.Log ("For some reason, the card deck was empty.");
		}

		int n = shuffleList.Capacity;

		while(n > 1)//A simple sorting algorithm to shuffle cards
		{
			n--;
			int k = Random.Range(0, n + 1);
			CardStruct temp = (CardStruct)shuffleList [k];
			shuffleList[k] = (CardStruct)shuffleList[n];
			shuffleList[n] = temp;
		}
	}

	//Instantiates CardStruct GameObjects for Doctor Cards
	public void MakeDoctorCards()
	{
		for (int i = 0; i < 12; i++) {
			tempCard = Instantiate (prefabCard);
			tempCard.cardID = i;
			doctorCardList.Add (tempCard);
		}
	}

	//Instantiates CardStruct GameObjects for Specialist Cards
	//Sets 'isSpecialistCard' true on each card
	public void MakeSpecialistCards()
	{
		for (int i = 0; i < 12; i++) {
			tempCard = Instantiate (prefabCard);
			tempCard.cardID = i;
			tempCard.isSpecialistCard = true;
		}
	}

	public CardStruct GetCurrentCard()
	{
		return (CardStruct)doctorCardList [0];
	}

}
