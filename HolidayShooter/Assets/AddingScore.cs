using UnityEngine;
using System.Collections;

public class AddingScore : MonoBehaviour
{
    [SerializeField]
    ScoreManagement scoreManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            scoreManager.CurrentScore = scoreManager.CurrentScore + 10;
        }
    }
}
