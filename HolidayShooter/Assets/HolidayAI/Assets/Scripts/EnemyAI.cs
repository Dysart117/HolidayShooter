using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{
	public Transform player;
	public float playerDistance;
	public float rotationDamping;
	public float moveSpeed;
	
	void Start () 
	{
		
	}
	
	
	void Update () {
		
		//if(HealthScrip01.isPlayerAlive)
		
		playerDistance = Vector3.Distance (player.position, transform.position);
		
		if (playerDistance < 25f) 
		{
			lookAtPlayer ();
		}
		if (playerDistance < 25f) 
		{
			if(playerDistance > 2f)
				
			{
				chase ();
			}
			else if(playerDistance < 2f)
			{
				attack();
			}
		}
	}
	void lookAtPlayer()
	{
		Quaternion rotation = Quaternion.LookRotation (player.position - transform.position);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationDamping);
	}
	
	void chase()
	{
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}
	void attack()
	{
		RaycastHit hit;
		if(Physics.Raycast (transform.position, transform.forward, out hit))
		{
			
			if(hit.collider.gameObject.tag == "Player")
			{

			}
		}
	}	
}



