//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Hiding_CameraCS : MonoBehaviour {
	
//	private GameObject Player ; 
//	public GameObject HidingCamera ; 
//	public AudioClip Sound ;
//	public GameObject text2 ;
//	// Use this for initialization
//	void Start () {
//		Player = GameObject.FindGameObjectsWithTag("Player")[0];
//		HidingCamera.SetActive(true);
//	}
	
//	// Update is called once per frame
//	void Update () {

//		if (Input.GetKeyUp(KeyCode.E))
//		{
//			text2.SetActive(false);
//			Player.SetActive(true);
//			HidingCamera.SetActive(false);
//			AudioSource.PlayClipAtPoint(Sound, transform.position);
//			AI_SystemCS.hiding = false;
//		}
//	}
//}

