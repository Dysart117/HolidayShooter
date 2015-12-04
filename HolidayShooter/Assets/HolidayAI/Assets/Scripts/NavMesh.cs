using UnityEngine;
using System.Collections;

public class NavMesh : MonoBehaviour 
{
	private NavMeshAgent Internal_Nav_Mesh_Agent;

	public GameObject Object_to_walk_to;

	void Start () 
	{
		Internal_Nav_Mesh_Agent = GetComponent<NavMeshAgent> ();
	}

	void Update () 
	{
		Internal_Nav_Mesh_Agent.SetDestination (Object_to_walk_to.transform.position);
	}
}
