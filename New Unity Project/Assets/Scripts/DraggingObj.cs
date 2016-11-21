using UnityEngine;
using System.Collections;

public class DraggingObj : MonoBehaviour {

	//The object that is being dragged
	public GameObject objToDrag;

	//The center of the object
	public Vector3 objCenter;

	//The position where the user touched the object
	public Vector3 touchPos;

	//A vector from the touch position to the object's center
	public Vector3 offset;

	//The new center of the object for dragging purposes
	public Vector3 newObjCenter;

	//Stores environmental object information
	RaycastHit hit;

	//The system knows that nothing is being dragged
	public bool draggingMode = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//This handles the first frame once the user clicks the left mouse button
		if (Input.GetMouseButtonDown(0))
		{

			//Creates a ray at mouse position
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			//If the ray hits a collider
			if (Physics.Raycast(ray, out hit))
			{

				//
				objToDrag = hit.collider.gameObject;

				//Updates object center
				objCenter = objToDrag.transform.position;

				//Updates the object position to mouse position
				touchPos=Camera.main.ScreenToWorldPoint(Input.mousePosition);

				//Updates the offset
				offset = touchPos - objCenter;

				//Object is now being dragged
				draggingMode = true;
			}
		}

		//Every frame that the user is holding down the left mouse button
		if (Input.GetMouseButton(0))
		{

			//Updates the object position to mouse position
			touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			//Updates the new center
			newObjCenter = touchPos - offset;

			//Updates the object's center
			objToDrag.transform.position = new Vector3(newObjCenter.x, newObjCenter.y);
		}

		//If the user lets go of the left mouse button
		if (Input.GetMouseButtonUp(0))
		{
			draggingMode = false;


			//Implement maze failure here - both particle and scene

		}			
	}
}
