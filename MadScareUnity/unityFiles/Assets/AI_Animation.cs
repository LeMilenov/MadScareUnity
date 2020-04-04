using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Animation : MonoBehaviour {

	// Use this for initialization
	Animator animator;
	bool Marche;
	Transform positionMonstre;
	float Lastx;
	void Start () {
		Marche = false;
		animator = GetComponent<Animator>();
		positionMonstre = GetComponent<Transform>();
	}	

	// Update is called once per frame
	void Update () {

		if(positionMonstre.position.x == Lastx)
		{
			Debug.Log("normal");
			animator.SetTrigger("Normal");
		}
		else
		{
			Debug.Log("marche");
			animator.SetTrigger("Marche");
			Lastx = positionMonstre.position.x;
		}
	}
}
