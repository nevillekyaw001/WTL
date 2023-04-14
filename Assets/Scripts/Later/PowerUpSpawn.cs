using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public float spawnRate = 1f;


    public GameObject[] PowerUps;

    private int randomIndex;

    private float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextTimeToSpawn)
        {
            randomIndex = Random.Range(0, PowerUps.Length);

            Instantiate(PowerUps[randomIndex], Vector3.zero, Quaternion.identity);

            nextTimeToSpawn = Time.time + 1 / spawnRate;
        }

    }
}
