using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MenuBackgroundScript : MonoBehaviour {
	public Image menuBackground;
	public Button rulesButton;
	public Button newGameButton;
	public Button cancelButton;
	public Button openMenuButton;
	public Button exitButton;

	// Use this for initialization
	void Start () {
		menuBackground.enabled = false;
		rulesButton.gameObject.SetActive (false);
		newGameButton.gameObject.SetActive (false);
		cancelButton.gameObject.SetActive (false);
		exitButton.gameObject.SetActive (false);

		var menuButtonInput = openMenuButton.GetComponent<Button> ();
		var openEvent = new Button.ButtonClickedEvent();
		openEvent.AddListener (ActivateMenu);
		menuButtonInput.onClick = openEvent;

		var cancelButtonInput = cancelButton.GetComponent<Button> ();
		var cancelEvent = new Button.ButtonClickedEvent();
		cancelEvent.AddListener (DeactivateMenu);
		cancelButtonInput.onClick = cancelEvent;

		var exitButtonInput = exitButton.GetComponent<Button> ();
		var exitEvent = new Button.ButtonClickedEvent ();
		exitEvent.AddListener (QuitGame);
		exitButtonInput.onClick = exitEvent;
	}

	void ActivateMenu()
	{
		menuBackground.enabled = true;
		rulesButton.gameObject.SetActive (true);
		newGameButton.gameObject.SetActive (true);
		cancelButton.gameObject.SetActive (true);
		exitButton.gameObject.SetActive (true);
		openMenuButton.gameObject.SetActive (false);
	}

	void DeactivateMenu()
	{
		menuBackground.enabled = false;
		rulesButton.gameObject.SetActive (false);
		newGameButton.gameObject.SetActive (false);
		cancelButton.gameObject.SetActive (false);
		exitButton.gameObject.SetActive (false);
		openMenuButton.gameObject.SetActive (true);
	}

	void QuitGame()
	{
		Application.Quit ();
	}

}
