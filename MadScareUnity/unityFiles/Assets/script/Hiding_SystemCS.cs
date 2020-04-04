//using UnityEngine;

//public class Hiding_SystemCS : MonoBehaviour {

//	private GameObject Player;
//	public GameObject HidingCamera;
//	public AudioClip Sound;
//	public GameObject text;
//	public GameObject text2;
//	bool activateTrigger = false;
//	// Use this for initialization
//	void Start () {
//		Player = GameObject.FindGameObjectsWithTag("Player")[0];
//		text.SetActive(false);  //Disabels the text.
//		text2.SetActive(false);
//		HidingCamera.SetActive(false);  //Disabels the the item in camera.
//		activateTrigger = false;    //Activates the Trigger
//	}

//	void OnTriggerExit(  Collider Col )
//	{
//		if (Col.tag == "Player")
//		{
//			activateTrigger = false;    //Disables the Trigger 
//			text.SetActive(false);
//		}
//	}

//	void OnTriggerEnter(Collider Col )
//	{
//		if (Col.tag == "Player")
//		{
//			activateTrigger = true;
//			text.SetActive(true);

//			if (Input.GetKeyDown(KeyCode.E))
//			{
//				activateTrigger = true;
//				text.SetActive(false);
//			}
//		}
//	}

//	void  Update()
//	{
//		if (activateTrigger && Input.GetKey(KeyCode.E))
//		{
//			HidingCamera.SetActive(true);
//			Player.SetActive(false);
//			activateTrigger = false;
//			text.SetActive(false);
//			text2.SetActive(true);
//			AudioSource.PlayClipAtPoint(Sound, transform.position);
//			AI_SystemCS.hiding = true;
//		}
//	}
//}
