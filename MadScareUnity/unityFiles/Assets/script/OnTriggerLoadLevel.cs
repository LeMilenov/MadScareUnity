using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerLoadLevel : MonoBehaviour {
	public GameObject UIText;
	public string nomNiveau;
	
	// Use this for initialization
	void Start () {
		UIText.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		if( other.gameObject.tag == "Player")
		{
			UIText.SetActive(true);
			if (UIText.activeInHierarchy == true && Input.GetButtonDown("Utiliser"))
			{
				Application.LoadLevel(nomNiveau);
			}
		}
	}
	void OnTriggerExit()
	{
		UIText.SetActive(false);
	}
}
