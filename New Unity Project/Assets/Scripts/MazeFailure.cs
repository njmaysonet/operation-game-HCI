using UnityEngine;
using System.Collections;

public class MazeFailure : MonoBehaviour {

    public ParticleSystem bloodSplatter;
    public AudioClip failure;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter()
    {
        Instantiate(bloodSplatter, transform.position, transform.rotation);
        GetComponent<AudioSource>().Play();
        Debug.Log("You lose!");
    }
}
