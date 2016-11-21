using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerNameScript : MonoBehaviour {
	public InputField iField;
	public GameCore core;
	private int pCount;
	private int currIndex;
	private PlayerStruct temp;
	public Text tField;
	void Start()
	{
		core = GameObject.Find ("GameCore").GetComponent<GameCore> ();
		var input = iField.GetComponent<InputField> ();
		var se = new InputField.SubmitEvent ();
		se.AddListener (SubmitName);
		input.onEndEdit = se;
		pCount = core.playerCount;
		currIndex = 0;
		tField.text = "Player 1 Name";
	}

	private void SubmitName(string arg)
	{
		Debug.Log ("Name input:" + arg);
		iField.text = "Enter name...";
		temp = (PlayerStruct)core.playerList [currIndex];
		temp.setPlayerName (arg);
		currIndex++;
		tField.text = "Player " + (currIndex + 1) + " Name";
		if(currIndex >= pCount)
		{
			//change scene
			Debug.Log("Exit name scene");
			SceneManager.LoadScene ("GameView");
		}
	}
}
