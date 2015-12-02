using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {

    //This script exists to manage the health player.
	
    public float m_Health;    //This float is set to public because 
	
	void Update ()
    {
	    if (m_Health <= 0)
        {   //This tests to see if the health is lower than zero.
            if (gameObject.tag == "Player")
            {
                //Put whatever gameover system we decide to use here.
            }
            if (gameObject.tag == "Enemy")
            {
                //Put whatever trigger we want for enemy death.
            }
        }
	}
}
//Thank you for using the Stanley Code Comment Service.