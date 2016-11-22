using UnityEngine;
using System.Collections;

public class ExitCheck : MonoBehaviour {
    
    public AudioClip success;

    // Use this for initialization
    void Start () {

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = success;
    }

    void OnCollisionEnter()
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("You win!");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
