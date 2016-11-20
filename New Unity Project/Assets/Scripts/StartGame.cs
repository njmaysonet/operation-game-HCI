using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void LoadNextScene()
	{
		Debug.Log ("Start button clicked.");
		SceneManager.LoadScene ("PlayerSelectMenu");
	}
}
