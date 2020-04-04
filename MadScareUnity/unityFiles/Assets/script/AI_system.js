//Script made by Strups Productions//

private var agent : UnityEngine.AI.NavMeshAgent; 
public var target : Transform; 
public var target2 : Transform; 
public var target3 : Transform; 
var waypointer : Transform;
var waypointer2 : Transform;
public var hiding : boolean = false;

function Start () 
{
    agent = GetComponent(UnityEngine.AI.NavMeshAgent);
    
}

function Update () 
{

        agent.SetDestination(target.position);
        agent.SetDestination(waypointer.position);

		if(!hiding)
			waypointer = target;

		else
		{			
			target = waypointer;
			target = waypointer2;
			target2 = waypointer2;
			agent.SetDestination(waypointer2.position);
			agent.SetDestination(target2.position);
		}
		if(Input.GetKeyUp(KeyCode.E))
		{
			hiding = false;
			target = waypointer;
		}


}







