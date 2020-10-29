using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldIntrection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject()) {
			GetInteraction();
		}
			
	}

	void GetInteraction(){

		Ray interactionray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit interactInfo;

		if(Physics.Raycast(interactionray,out interactInfo,Mathf.Infinity)){
			GameObject interactedObj = interactInfo.collider.gameObject;
			if (interactedObj.tag == "interactable object") {
				Debug.Log ("Interaction");
			} else {

			}
		}
	}


}
