using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_monstre : MonoBehaviour {

	// Use this for initialization
	public GameObject monstre;
	public float tempsInitial = 1000;
	public float tempsMonstreInitial = 2000;
	public AudioClip bruitAmbiant;
	public AudioClip bruitMonstre;
	public AudioClip arriveeMonstre;
	AudioSource audioAmbiance;
	AudioSource audioMonstre;
	float temps;
	float tempsMonstre;
	public Vector3 positionInitiale;
	void Start () {
		audioAmbiance = GetComponent<AudioSource>();
		audioMonstre = monstre.GetComponent<AudioSource>();
		monstre.SetActive(false);
		temps = tempsInitial;
		tempsMonstre = tempsMonstreInitial;
	}

	// Update is called once per frame
	
	void FixedUpdate () {
		if (!audioAmbiance.isPlaying)
		{
			audioAmbiance.PlayOneShot(bruitAmbiant, 0.7F);
		}			
		Debug.Log(temps);
		Debug.Log(tempsMonstre);
		if (temps == 1000)
		{
			//bruit menacant qui dure 15 frames			
				audioAmbiance.PlayOneShot(arriveeMonstre, 0.6F);
			
			temps--;
		}
		else if (temps == 1)
		{
			monstre.SetActive(true);
			// set a l entree du niveau
			monstre.transform.position = positionInitiale;
			temps--;
		}
		else if(temps == 0)
		{
			// le laisser suivre son chemin
			if (!audioMonstre.isPlaying)
			{
				audioMonstre.PlayOneShot(bruitMonstre, 0.6F);

			}

			if (tempsMonstre == 0)
			{
				monstre.SetActive(false);
				temps = tempsInitial;
				tempsMonstre = tempsMonstreInitial;
			}
			tempsMonstre--;

		}
		else 
		{
			temps--;
		}
	}
	
}
