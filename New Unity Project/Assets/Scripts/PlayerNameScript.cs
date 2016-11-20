using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events

public class PlayerNameScript : MonoBehaviour {
	public InputField iField;

	void Start()
	{
		var input = iField.GetComponent<InputField> ();
		var se = new InputField.SubmitEvent ();
	}

	private void SubmitName(string arg)
	{
		Debug.Log (arg);
	}
}
