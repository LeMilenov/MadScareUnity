//Script made by Strups Productions//

var AISscript : AI_system;
var Player : GameObject; 
var HidingCamera : GameObject; 
var Sound : AudioClip;
var text : GameObject;
var text2 : GameObject;
var activateTrigger : boolean = false; 

function Start() {
	text.SetActive(false);	//Disabels the text.
	text2.SetActive(false);
	HidingCamera.SetActive(false);	//Disabels the the item in camera.
	activateTrigger = false;	//Activates the Trigger 
}


function OnTriggerExit (Col : Collider) 
{
	if(Col.tag =="Player")
	{
		activateTrigger = false;	//Disables the Trigger 
		text.SetActive(false);
	}
}

function OnTriggerEnter (Col : Collider) 
{
	if(Col.tag =="Player")
	{
		activateTrigger = true;
		text.SetActive(true);

		if(Input.GetKeyDown(KeyCode.E))
		{
			activateTrigger = true;
			text.SetActive(false);
		}
	}
}

function Update () 
{
	if (activateTrigger && Input.GetKey(KeyCode.E))
	{
		HidingCamera.SetActive(true); 
		Player.SetActive(false);
		activateTrigger = false;
		text.SetActive(false);
		text2.SetActive(true);
		AudioSource.PlayClipAtPoint(Sound, transform.position); 
		AISscript.hiding = true;
	}
}


