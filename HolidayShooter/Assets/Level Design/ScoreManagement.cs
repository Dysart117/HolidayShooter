using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManagement : MonoBehaviour
{
    [SerializeField]
    Text ScoreText;

    public int CurrentScore = 0;

    void Start()
    {
        ScoreText.text = "Score: " + CurrentScore;
    }

    void Update()
    {
        ScoreText.text = "Score: " + CurrentScore;
    }

}
