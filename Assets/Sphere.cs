using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sphere : MonoBehaviour
{
	[SerializeField] private GameObject target;
	// Use this for initialization
	void Start () 
	{
		NavMeshAgent agent = GetComponent<NavMeshAgent> ();
		agent.speed = 10;
		agent.destination = target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
