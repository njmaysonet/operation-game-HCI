using UnityEngine;
using System.Collections;

public class MazeFailure : MonoBehaviour {

    //The particle system used to display a blood splatter upon a maze failure
    public ParticleSystem bloodSplatter;

    //The audio clip that plays a song upon a maze failure
    public AudioClip failure;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //If the user hits a maze wall
    IEnumerator OnCollisionEnter2D()
    {
      
        //Plays the failure particle system effect
        bloodSplatter.Play();

        //Plays the failure sound
        GetComponent<AudioSource>().Play();

        //Informs the user of a loss
        Debug.Log("You lose!");

        //Waits 4 seconds before destroying the game object in order for the sound clip to play 
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }
}
