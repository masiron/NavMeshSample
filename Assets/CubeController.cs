using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeController : MonoBehaviour 
{

	[SerializeField] private Transform target;
	[SerializeField] private Transform pos1;
	[SerializeField] private Transform pos2;
	[SerializeField] private GameObject obstacle;
	private NavMeshAgent agent;
	private bool flag;
	// Use this for initialization
	void Start () 
	{
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.C)) 
		{
			flag = true;
		}
		if (Input.GetKey (KeyCode.V)) 
		{
			flag = false;
		}

		if (flag == true) {
			obstacle.transform.position = new Vector3 (3.0f, 2.0f, 2.0f);
		}
		else
		{
			obstacle.transform.position = new Vector3 (3.0f, 2.0f, -2.0f);
		}
		
		agent.SetDestination (target.position);	
	}
}
