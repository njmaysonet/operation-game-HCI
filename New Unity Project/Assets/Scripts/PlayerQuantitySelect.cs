using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class PlayerQuantitySelect : MonoBehaviour
{	
	public int playerCount;
	public Dropdown PlayerNumDropdown;

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
	private void DropdownValueChangedHandler(Dropdown target)
	{
		Debug.Log("selected: " + target.value);
		playerCount = target.value + 1;
	}
		
}
