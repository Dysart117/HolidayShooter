using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GunFire : MonoBehaviour {

    //This script exists to manage bullet object pooling and to summon the bullets when they are fired.

    [SerializeField] float kFireTime = .05f; //This is the time between bullets are fired.
    [SerializeField] float m_CoolDown; //This float helps see if the bullet can be fired.
    [SerializeField] GameObject m_Bullet; //This gameobject is the bullet that is fired.

    [SerializeField] int kPooledAmount = 20; //This indicates how many bullets are created for the object pooling.
    List<GameObject> m_Bullets; //This list manages the bullets created in the object pools.
	
	void Start ()
    {   //This creates the pool of bullets that can be called.
        m_Bullets = new List<GameObject>();
        for(int i = 0; i < kPooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(m_Bullet);
            obj.SetActive(false);
            m_Bullets.Add(obj);
        }
	}
	
	
	void Update ()
    {
	    if(Input.GetMouseButton(0))
        {   //This checks to see if the mouse button is clicked.
            if (m_CoolDown < Time.time)
            {   //This checks to see if the gun can fire yet.
                m_CoolDown = m_CoolDown + kFireTime;
                for (int i = 0; i < m_Bullets.Count; i++)
                {   //This goes through the list of bullets.
                    if (!m_Bullets[i].activeInHierarchy)
                    {   //This checks to see if a bullet is active.
                        m_Bullets[i].transform.position = transform.position;   //This sets the bullets position to that of gameObject.
                        m_Bullets[i].transform.rotation = transform.rotation;   //This set the bullets rotation to that of gameObject.
                        m_Bullets[i].SetActive(true);   //This sets the bullet to active.
                        break;  //This breaks the loop.
                    }
                }
            }
        }
	}
}
//Thank you for using the Stanley Code Comment Service.