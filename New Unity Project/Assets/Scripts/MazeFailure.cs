using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MazeFailure : MonoBehaviour {

    public ParticleSystem bloodSplatter;
    public AudioClip failure;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator OnCollisionEnter2D()
    {
      
        bloodSplatter.Play();
        GetComponent<AudioSource>().Play();
        Debug.Log("You lose!");
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
		SceneManager.LoadScene ("GameView");
    }
}
