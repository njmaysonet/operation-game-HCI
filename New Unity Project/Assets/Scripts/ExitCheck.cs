using UnityEngine;
using System.Collections;

public class ExitCheck : MonoBehaviour {
    
    //The audio clip used for a successful maze run
    public AudioClip success;

    // Use this for initialization
    void Start () {

        //The audio file will not play on the start of this scene
        GetComponent<AudioSource>().playOnAwake = false;

        //Acquires the audio clio
        GetComponent<AudioSource>().clip = success;
    }


    //If the user enters the exit area
    void OnCollisionEnter()
    {

        //Plays the audio clip
        GetComponent<AudioSource>().Play();

        //Informs the user of their successful maze run
        Debug.Log("You win!");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
