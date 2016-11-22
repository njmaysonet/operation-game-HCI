using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerQuantitySelect : MonoBehaviour
{	
	public int playerCount;
	public Dropdown PlayerNumDropdown;
	public GameObject gc;

	// Use this for initialization
	void Awake() {
		playerCount = 0;
		PlayerNumDropdown.onValueChanged.AddListener (delegate {
			DropdownValueChangedHandler (PlayerNumDropdown);
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//kill the listener
	void Destroy()
	{
		PlayerNumDropdown.onValueChanged.RemoveAllListeners ();
	}

	//send value to log and change playerCount to index of option + 1
	public void DropdownValueChangedHandler(Dropdown target)
	{
		Debug.Log("selected index: " + target.value);
		playerCount = target.value + 1;
		//call functions from GameCore to set up players
		gc.GetComponent<GameCore>().SetPlayerCount (target.value + 1);
		gc.GetComponent<GameCore> ().CreatePlayers ();
		SceneManager.LoadScene ("PlayerNameMenu");
	}
		
}
