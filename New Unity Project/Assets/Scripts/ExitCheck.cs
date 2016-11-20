using UnityEngine;
using System.Collections;

public class ExitCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "cursor")
        {
            Debug.Log("You win!");
        }
    }
}
