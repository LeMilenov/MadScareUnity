#pragma strict

var AISscript : AI_system;
var Player : GameObject; 
var HidingCamera : GameObject; 
var Sound : AudioClip;
var text2 : GameObject;


function Start() {
    HidingCamera.SetActive(true);
}

function Update () {

    if(Input.GetKeyUp(KeyCode.E)) 
    {
	    text2.SetActive(false);
	    Player.SetActive(true);
	    HidingCamera.SetActive(false);
	    AudioSource.PlayClipAtPoint(Sound, transform.position); 
	    AISscript.hiding = false;
    }
}