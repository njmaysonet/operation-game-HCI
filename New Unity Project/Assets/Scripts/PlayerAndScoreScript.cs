using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerAndScoreScript : MonoBehaviour {
	public GameCore core;
	public string currentPlayerText;
	public int currentPlayerScore;
	public Text playerAndScoreText;
	private PlayerStruct temp;
	bool playerNeedUpdate = false;

	// Use this for initialization
	void Start () {
		core = GameObject.Find ("GameCore").GetComponent<GameCore> ();
		temp = (PlayerStruct)core.playerList [core.currentPlayerID];
		currentPlayerText = temp.getPlayerName();
		currentPlayerScore = temp.score;
		playerAndScoreText.text = "Player " + (core.currentPlayerID + 1) +" Name: " + currentPlayerText + "\n" + "Score: "
			+ currentPlayerScore;
	}

	void Update()
	{
		if (playerNeedUpdate) {
			temp = (PlayerStruct)core.playerList [core.currentPlayerID];
			currentPlayerText = temp.getPlayerName ();
			currentPlayerScore = temp.score;
			playerAndScoreText.text = "Player " + (core.currentPlayerID + 1) + " Name: " + currentPlayerText + "\n" + "Score: "
			+ currentPlayerScore;
			playerNeedUpdate = false;
		}
	}

	public void UpdatePlayerName()
	{
		playerNeedUpdate = true;
	}
}
