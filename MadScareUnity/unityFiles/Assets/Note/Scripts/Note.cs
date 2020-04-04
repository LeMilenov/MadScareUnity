using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Note : MonoBehaviour
{
    public Image noteImage;
    public GameObject HideNoteButton;
    public GameObject playerObject;
	public GameObject so;
	
    public bool noteVue = false;
    // Use this for initialization
    void Start()
    {
        noteImage.enabled = false;
        HideNoteButton.SetActive(false);

    }

    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        playerObject.GetComponent<FirstPersonController>().enabled = false;

        HideNoteButton.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
		
    }
    public void HideNoteImage()
    {
		if (!noteVue)
		{
			noteVue = true;
			so.GetComponent<SceneManager>().notesCounts++;
			Debug.Log("notes" + so.GetComponent<SceneManager>().notesCounts);

		}
		
        noteImage.enabled = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
		
        playerObject.GetComponent<FirstPersonController>().enabled = true;
        HideNoteButton.SetActive(false);
    }

}
 