using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	public GameObject Text;
	void Start()
	{
		Text.SetActive(false);
	}
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Player")
		{
			Text.SetActive(true);
		}
		
	}
	
}
