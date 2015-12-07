using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    //This script exists to manage when the gun exists.

    public bool m_GunUp;
    [SerializeField] GameObject kGun;

    void Update ()
    {
        if (m_GunUp)
        {
            kGun.SetActive(true);
        }
        if (!m_GunUp)
        {
            kGun.SetActive(false);
        }
	}
}
