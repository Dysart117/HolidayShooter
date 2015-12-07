using UnityEngine;
using System.Collections;

public class GronchAnimations : MonoBehaviour {

    //This script exists to manage the Gronch's animations.

    Animator m_Animator;
    Rigidbody m_Rigidbody;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update ()
    {
	    if(m_Rigidbody.velocity.x > 0||m_Rigidbody.velocity.y > 0|| m_Rigidbody.velocity.z > 0)
        {
            m_Animator.SetBool("IsWalking", true);
            GameObject.Find("Gun").GetComponent<Gun>().m_GunUp = true;
        }
        else
        {
            m_Animator.SetBool("IsWalking", false);
            GameObject.Find("GunM").GetComponent<Gun>().m_GunUp = false;
        }
	}

    void PlayerDeath()
    {
        m_Animator.SetBool("IsDead", true);
    }
}
