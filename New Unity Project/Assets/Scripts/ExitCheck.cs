using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitCheck : MonoBehaviour {
    
    public AudioClip success;

    // Use this for initialization
    void Start () {

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = success;
    }

	void OnCollisionEnter()
    {
       //GetComponent<AudioSource>().Play();
        Debug.Log("You win!");
		SceneManager.LoadScene ("WinScreen");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
