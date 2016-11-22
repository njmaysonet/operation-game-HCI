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
		/*Since 'GameCore' comes from another scene we have
		look for it in runtime*/
		core = GameObject.Find ("GameCore").GetComponent<GameCore> ();
		//Get the iField
		var input = iField.GetComponent<InputField> ();
		//Creat an event container variable
		var se = new InputField.SubmitEvent ();
		//Attach the SubmitName method as a listener to the event
		se.AddListener (SubmitName);
		input.onEndEdit = se;
		//Set up of count and indices
		pCount = core.playerCount;
		currIndex = 0;
		tField.text = "Player 1 Name";
	}

	//Listens to submit event of input field and stores player names
	private void SubmitName(string arg)
	{
		Debug.Log ("Name input:" + arg);
		iField.text = "Enter name...";
		temp = (PlayerStruct)core.playerList [currIndex];
		temp.setPlayerName (arg);
		currIndex++;
		if (currIndex >= pCount) {
			//disable input field
			iField.interactable = false;
			//change scene
			Debug.Log ("Exit name scene");
			SceneManager.LoadScene ("GameView");
		} else {
			tField.text = "Player " + (currIndex + 1) + " Name";
		}
	}
}
