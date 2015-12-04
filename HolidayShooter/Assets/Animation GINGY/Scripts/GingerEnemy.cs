using UnityEngine;
using System.Collections;

public class GingerEnemy : MonoBehaviour {

    //This script exists to manage the gingerbread people's animations.

    Animator m_Animator;

    void Start ()
    {
        m_Animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test1");
        if (other.tag == "Player")
        {
            Debug.Log("Test2");
            m_Animator.SetBool("IsPunching", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            m_Animator.SetBool("IsPunching", true);
        }
    }

    public void Dead()
    {
        m_Animator.SetBool("IsDead", true);
    }
}
