using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinSceneExit : MonoBehaviour {

	public GameObject exitButtonObj;
	public GameCore gCore;
	public Text WinText;
	private Button exitButton;

	void Start()
	{
		gCore = GameObject.Find ("GameCore").GetComponent<GameCore> ();
		var exitButtonInput = exitButtonObj.GetComponent<Button> ();
		var exitEvent = new Button.ButtonClickedEvent ();
		exitEvent.AddListener (Exit);
		exitButtonInput.onClick = exitEvent;
		PlayerStruct curPlayer = (PlayerStruct)gCore.playerList [gCore.currentPlayerID];
		string nameText = curPlayer.getPlayerName ();

		WinText.text = "Player " + curPlayer.playerID + ": " + nameText + "\n"
		+ "Score: " + curPlayer.score + 1337;
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
