using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerAndScoreScript : MonoBehaviour {
	public GameCore core;
	public string currentPlayerText;
	public int currentPlayerScore;
	public Text playerAndScoreText;
	private PlayerStruct temp;

	// Use this for initialization
	void Start () {
		core = GameObject.Find ("GameCore").GetComponent<GameCore> ();
		temp = (PlayerStruct)core.playerList [0];
		currentPlayerText = temp.getPlayerName();
		currentPlayerScore = temp.score;
		playerAndScoreText.text = "Name: " + currentPlayerText + "\n" + "Score: "
			+ currentPlayerScore;
	}

	//this needs fleshing out
}
