using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public float moveSpeed = 400f;

    public float shrinkSpeed = 3f; //hexagons' shrink speed

    public float spawnRate = 1f; // amount of hexagon spawn rate

    float elapsedSeconds = 0; // time delay counter

    public GameObject[] Shades; // prefabs of enemies

    private int randomIndex; // randomize number for choosing enemies

    private float nextTimeToSpawn = 0f;


    // Update is called once per frame
    void Update()
    {
        
        if (Time.time >= nextTimeToSpawn)
        {
            randomIndex = Random.Range(0, Shades.Length);

            Instantiate(Shades[randomIndex], Vector3.zero, Quaternion.identity); // instantiate means generate a copy of inserted prefab

            nextTimeToSpawn = Time.time + 1 / spawnRate;
        }


        elapsedSeconds += Time.deltaTime; //time delay script

        if (elapsedSeconds > 20f)
        {
            shrinkSpeed = 3.5f;


            moveSpeed = 510f;
            spawnRate = 1.1f;
            
            

        }

        if (elapsedSeconds > 40f)
        {
            shrinkSpeed = 4f;

            moveSpeed = 520f;
            spawnRate = 1.3f;
            
        }

        if (elapsedSeconds > 60f)
        {
            shrinkSpeed = 4.5f;

            moveSpeed = 530f;
            
            spawnRate = 1.5f;
            

            
        }

        if (elapsedSeconds > 80f)
        {
            
            shrinkSpeed = 5f;

            moveSpeed = 550;
            spawnRate = 1.7f;
            
        }

        if (elapsedSeconds > 100f)
        {
            shrinkSpeed = 5.5f;

            moveSpeed = 570f;
            spawnRate = 1.9f;
            
        }
        if (elapsedSeconds > 120f)
        {
            
            shrinkSpeed = 6f;


            spawnRate = 2f;
            
            moveSpeed = 580;

        }
        if (elapsedSeconds > 140f)
        {
            shrinkSpeed = 6.5f;

            moveSpeed = 590f;
            spawnRate = 2.2f;
            
        }
        if (elapsedSeconds > 180f)
        {
            shrinkSpeed = 7f;


            spawnRate = 2.5f;
            
            moveSpeed = 600f;
        }
        
    }

    

}
