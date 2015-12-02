using UnityEngine;
using System.Collections;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;

    [SerializeField]
    Transform[] SpawnPoints;

    void Start()
    {
        int SpawnPointIndex = Random.Range(0, SpawnPoints.Length);

        Instantiate(Enemy, SpawnPoints[SpawnPointIndex].position, SpawnPoints[SpawnPointIndex].rotation);
    }
}
