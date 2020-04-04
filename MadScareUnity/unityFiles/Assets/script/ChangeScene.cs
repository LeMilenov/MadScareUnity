using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    public int doorNumber;
    public GameObject Entrer;

    private void OnTriggerEnter(Collider other)
    {
		Entrer.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
		Entrer.SetActive(false);
	}
	private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.instance.LoadScene(doorNumber);
        }
    }

}
