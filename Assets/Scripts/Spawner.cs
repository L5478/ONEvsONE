using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject smallCirclePrefab;
    public GameObject bigCirclePrefab;
    public GameObject chengerPrefab;

    private GameObject circleToSpawn;

    public float distance = 12f;

    private Vector3 spawnPosition;
    public int smallCircleRate = 3;
    private int count = 0;

    private void Start()
    {
        spawnPosition = transform.position;
        Instantiate(bigCirclePrefab, spawnPosition, Quaternion.identity, transform);
        Instantiate(chengerPrefab, spawnPosition + Vector3.up * distance/2, Quaternion.identity, transform);
    }

    public void Spawn()
    {
        spawnPosition += Vector3.up * distance;

        if (count >= smallCircleRate)
        {
            circleToSpawn = smallCirclePrefab;
            count = 0;
        }
        else
        {
            circleToSpawn = bigCirclePrefab;
        }

        Instantiate(circleToSpawn, spawnPosition, Quaternion.identity, transform);
        Instantiate(chengerPrefab, spawnPosition + Vector3.up * distance / 2, Quaternion.identity, transform);

        count++;
    }

}
