using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour {

    public bool affichageText;

    public int batteryDeLaLampe;

    public bool destroyObject;

    private void Start()
    {
        affichageText = false;
    }

    private void OnTriggerStay(Collider other)
    {
        affichageText = true;
        if (!destroyObject)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                int batterytemp = 0;
                batteryDeLaLampe = Flashlight.batteryLevel;
                int batterieRechargeValeur = 5;
                batterytemp = batteryDeLaLampe + batterieRechargeValeur;
                if (batterytemp > 100)
                {
                    Flashlight.batteryLevel = 100;
                } else
                {
                    Flashlight.batteryLevel += batterieRechargeValeur;
                }
                destroyObject = true;

                if (destroyObject)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        affichageText = true;
    }

    private void OnTriggerExit(Collider other)
    {
        affichageText = false;
    }

    private void OnGUI()
    {
        if (affichageText)
        {
            GUI.Box(new Rect(Screen.width / 2.55f, Screen.height / 124.98f, Screen.width / 3.78f, Screen.height / 16.1f), "Peser 'E' pour ramasser");
        }
    }
}
