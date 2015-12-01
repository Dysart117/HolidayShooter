using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    //This script exists to control the bullet.
    
    [SerializeField] float kBulletSpeed;    //This controls the speed of the bullet.

	void Start ()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * kBulletSpeed);    //This propels the bullets forward.

        Invoke("Shutdown", 3);  //This disables the bullet 3 seconds after it was made active.
	}
	
	void Shutdown()
    {   //This resets the velocity of the bullet, and disables it.
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        gameObject.SetActive(false);
    }
}
