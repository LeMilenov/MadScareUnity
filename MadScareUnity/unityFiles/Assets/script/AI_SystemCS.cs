//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AI_SystemCS : MonoBehaviour {

//	public GameObject NavMesh;
//	public  Transform target;
//	public Transform target2;
//	public Transform target3;
//	private Transform waypointer;
//	private Transform waypointer2;
//	static public bool hidin = false;

//	// Use this for initialization
//	void Start () {
		
//		waypointer = GameObject.FindGameObjectsWithTag("waypoint").Transform;
//		waypointer2 = GameObject.FindGameObjectsWithTag("waypoint").Transform;

//	}

//	// Update is called once per frame
//	void Update () {
//		NavMesh.SetDestination(target.position);
//		NavMesh.SetDestination(waypointer.position);

//		if (!hiding)
//			waypointer = target;

//		else
//		{
//			target = waypointer;
//			target = waypointer2;
//			target2 = waypointer2;
//			NavMesh.SetDestination(waypointer2.position);
//			NavMesh.SetDestination(target2.position);
//		}
//		if (Input.GetKeyUp(KeyCode.E))
//		{
//			hiding = false;
//			target = waypointer;
//		}
//	}
//}


	

