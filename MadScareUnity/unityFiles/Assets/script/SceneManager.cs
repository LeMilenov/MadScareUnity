using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
    public static SceneManager instance = null;
    public int currentDoorNumber;
    private GameObject player;
    public GameObject[] doorsArray;
    public  int notesCounts = 0;
    public GameObject NoEnter = null;
    float dureeText = 10f;
	AudioSource sourceAudioDuScript;
	public AudioClip AudioPorteBarree;
	
	void Awake () {
		Debug.Log("notes" + notesCounts);

		sourceAudioDuScript = GetComponent<AudioSource>();
		if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        } else if (instance != null) {
            Destroy(gameObject);
        }
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
			
        }
	}

    void OnLevelWasLoaded()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        doorsArray = GameObject.FindGameObjectsWithTag("Door");

        for (int i = 0; i < doorsArray.Length; i++)
        {
            if (doorsArray[i].GetComponent<ChangeScene>().doorNumber == currentDoorNumber)
            {
                player.transform.position = doorsArray[i].transform.position;
            }
        }
    }

    public void LoadScene(int passedDoorNumber)
    {
        currentDoorNumber = passedDoorNumber;
		if(Application.loadedLevel == 0)
		{
			Application.LoadLevel(1);
		}
        else if (Application.loadedLevel == 1) // si on est dans le niveau exterieur
        {            
			if (passedDoorNumber == 1)
			{
				Application.LoadLevel(2);
			}            
        }
        else if (Application.loadedLevel == 2) // si on est dans le niveau interieur
        {
            if (passedDoorNumber == 1) //si on veux ouvrir la porte principale
            {
                if (notesCounts == 5) // on doit avoir 5 notes 
                {
                    Application.LoadLevel(1);
                } else
                {
					NoEnter.SetActive(true);
                }
            }

            if (passedDoorNumber == 2) // si on vx aller dans le niveau jardin
            {
				if (notesCounts == 2) // on doit avoir 2 notes  principal + chambre
				{
					Application.LoadLevel(3);
				}
				else
				{
					NoEnter.SetActive(true);

				}
			}

            if (passedDoorNumber == 3)
            {
                Application.LoadLevel(4); // si on vx aller dans le niveau chambre
			}

        }
        else if (Application.loadedLevel == 4) //si on est dans le niveau chambre
        {
			if (notesCounts == 2) // on doit avoir 2 notes  principal + chambre
			{
				Application.LoadLevel(2);
			}
			else
			{
				NoEnter.SetActive(true);

			}
		} 
        else if (Application.loadedLevel == 3) // si on est dans le jardin
        {
            if (passedDoorNumber == 2) // si on vx retourner dans la maison
            {
				if (notesCounts == 3) // on doit avoir 3 notes principal + chambre + cabanon
				{
					Application.LoadLevel(2);
				}
				else
				{
					NoEnter.SetActive(true);

				}
			}

            if (passedDoorNumber == 4)
            {
                Application.LoadLevel(5);
            }
        }
		else if (Application.loadedLevel == 4)
        {
            Application.LoadLevel(3);
        }

    }
    private void Update()
    {
        
        if (NoEnter.active){
            if(dureeText > 0)
            {
				if (!sourceAudioDuScript.isPlaying)
				{
					sourceAudioDuScript.PlayOneShot(AudioPorteBarree, 0.7f);
				}
				dureeText--;
            } else
            {
				NoEnter.SetActive(false);
				dureeText = 20f;
            }
        }

    }

}
