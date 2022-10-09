using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardcoreSpawner : MonoBehaviour
{
    public Slider progessbar;

    public float rotateSpeed = 1;

    public float shrinkSpeed = 3f; //hexagons' shrink speed

    public float spawnRate = 1f; // amount of hexagon spawn rate

    float elapsedSeconds = 0; // time delay counter

    float maxTime = 177f;

    public GameObject[] Shades; // prefabs of enemies

    private int Index = 0; // randomize number for choosing enemies

    private float nextTimeToSpawn = 0f;

    float percentage;

    // Update is called once per frame
    void Update()
    {
        percentage = (elapsedSeconds / maxTime) * 100f;



        progessbar.value = percentage;

        if (Time.time >= nextTimeToSpawn)
        {


            Instantiate(Shades[Index], Vector3.zero, Quaternion.identity); // instantiate means generate a copy of inserted prefab

            nextTimeToSpawn = Time.time + 1 / spawnRate;
        }




        elapsedSeconds += Time.deltaTime; //time delay script

        if (elapsedSeconds > 14f)
        {
            shrinkSpeed = 3f;


            spawnRate = 1f;
            rotateSpeed = -90;
            Debug.Log("This is 1st turn");

        }

        if (elapsedSeconds > 28.5f)
        {
            shrinkSpeed = 3.5f;


            spawnRate = 1.2f;

            rotateSpeed = 30;
            Debug.Log("This is 2nd turn");
        }

        if (elapsedSeconds > 32.6f)
        {
            shrinkSpeed = 4f;

            rotateSpeed = 30;
            spawnRate = 1.4f;
            Debug.Log("This is Bugged");
        }

        if (elapsedSeconds > 38f)
        {

            shrinkSpeed = 4.5f;


            rotateSpeed = -90;
            spawnRate = 1.6f;
            Debug.Log("This is Hey Melody");
        }
        if (elapsedSeconds > 40f)
        {

            shrinkSpeed = 4.5f;

            Index = 1;
            rotateSpeed = -90;
            spawnRate = 1.6f;
            Debug.Log("This is Hey Hexagons and it should start");
        }


        if (elapsedSeconds > 43f)
        {
            shrinkSpeed = 4.5f;

            Index = 0;
            rotateSpeed = 20;
            spawnRate = 1.6f;
            Debug.Log("This is Hey Hexagons and it should end");
        }
        if (elapsedSeconds > 47.5f)
        {

            shrinkSpeed = 5.5f;

            rotateSpeed = -90;
            spawnRate = 1.8f;
            Debug.Log("This is Hey melody");
        }

        if (elapsedSeconds > 50)
        {
            shrinkSpeed = 4.5f;

            Index = 1;
            rotateSpeed = -90;
            spawnRate = 1.6f;
            Debug.Log("This is Hey Hexagons and it should start");
        }

        if (elapsedSeconds > 52.5f)
        {
            shrinkSpeed = 4.5f;
            Index = 0;
            rotateSpeed = 20;
            spawnRate = 1.6f;
            Debug.Log("This is Hey Hexagons and it should end");
        }
        if (elapsedSeconds > 55f)
        {
            shrinkSpeed = 3f;

            rotateSpeed = 70;
            spawnRate = 1.2f;
            Debug.Log("transition");
        }


        if (elapsedSeconds > 57f)
        {
            shrinkSpeed = 5.5f;

            rotateSpeed = -50;
            spawnRate = 2.3f;
            Debug.Log("Meow Melody");
        }
        if (elapsedSeconds > 62f)
        {
            shrinkSpeed = 5.5f;

            rotateSpeed = 5;
            spawnRate = 2.3f;
            Debug.Log("Meow Melody");
        }
        if (elapsedSeconds > 67f)
        {
            shrinkSpeed = 5.5f;

            rotateSpeed = -50;
            spawnRate = 2.3f;
            Debug.Log("Meow Melody");
        }
        if (elapsedSeconds > 72f)
        {
            shrinkSpeed = 5.5f;

            rotateSpeed = 5;
            spawnRate = 2.3f;
            Debug.Log("Meow Melody");
        }
        if (elapsedSeconds > 76f)
        {
            shrinkSpeed = 6.5f;

            rotateSpeed = -50;
            spawnRate = 2.3f;

        }

        if (elapsedSeconds > 77f)
        {
            shrinkSpeed = 6.5f;

            rotateSpeed = 70;
            spawnRate = 2.3f;

        }
        if (elapsedSeconds > 78f)
        {
            shrinkSpeed = 4.5f;

            Index = 1;
            rotateSpeed = -90;
            spawnRate = 1.6f;
            Debug.Log("It should start");
        }
        if (elapsedSeconds > 81.5f)
        {
            shrinkSpeed = 4.5f;
            Index = 0;
            rotateSpeed = 20;
            spawnRate = 1.6f;
            Debug.Log("It should end");
        }
        if (elapsedSeconds > 85.5f)
        {
            shrinkSpeed = 6.5f;

            rotateSpeed = -90;
            spawnRate = 2.3f;

        }

        if (elapsedSeconds > 88.5f)
        {
            shrinkSpeed = 4.5f;

            Index = 1;
            rotateSpeed = -90;
            spawnRate = 1.6f;
            Debug.Log("It should start");
        }

        if (elapsedSeconds > 91f)
        {
            shrinkSpeed = 4.5f;
            Index = 0;
            rotateSpeed = 20;
            spawnRate = 1.6f;
            Debug.Log("It should end");
        }
        if (elapsedSeconds > 94f)
        {
            shrinkSpeed = 6f;
            Index = 2;
            rotateSpeed = 70;
            spawnRate = 2.2f;

        }
        if (elapsedSeconds > 101f)
        {
            shrinkSpeed = 6f;

            rotateSpeed = -140;
            spawnRate = 2.2f;

        }
        if (elapsedSeconds > 105f)
        {
            shrinkSpeed = 6f;

            rotateSpeed = 70;
            spawnRate = 2.2f;

        }
        if (elapsedSeconds > 110f)
        {
            shrinkSpeed = 6f;

            rotateSpeed = -140;
            spawnRate = 2.2f;

        }
        if (elapsedSeconds > 115f)
        {
            Index = 0;
            shrinkSpeed = 7f;

            rotateSpeed = 30;
            spawnRate = 2f;

        }
        if (elapsedSeconds > 124.5f)
        {
            shrinkSpeed = 6.5f;

            rotateSpeed = -90;
            spawnRate = 1.9f;

        }
        if (elapsedSeconds > 131.5f)
        {
            shrinkSpeed = 6.5f;

            rotateSpeed = Random.Range(-300, 100);
            spawnRate = 1.9f;

        }
        if (elapsedSeconds > 134.5f)
        {

            shrinkSpeed = 6.5f;


            rotateSpeed = -90;
            spawnRate = 2.3f;

        }
        if (elapsedSeconds > 136f)
        {

            shrinkSpeed = 5.5f;

            Index = 1;
            rotateSpeed = -90;
            spawnRate = 1.6f;
            Debug.Log("It should start");

        }
        if (elapsedSeconds > 139.5f)
        {

            shrinkSpeed = 5.5f;
            Index = 0;
            rotateSpeed = 20;
            spawnRate = 1.6f;
            Debug.Log("It should end");

        }
        if (elapsedSeconds > 143.5f)
        {

            shrinkSpeed = 6.5f;


            rotateSpeed = -90;
            spawnRate = 2.3f;

        }

        if (elapsedSeconds > 145f)
        {

            shrinkSpeed = 5.5f;

            Index = 1;
            rotateSpeed = -90;
            spawnRate = 1.6f;
            Debug.Log("It should start");

        }

        if (elapsedSeconds > 148.5f)
        {

            shrinkSpeed = 5.5f;
            Index = 0;
            rotateSpeed = 20;
            spawnRate = 1.6f;
            Debug.Log("It should end");

        }

        if (elapsedSeconds > 151f)
        {

            shrinkSpeed = 6.5f;


            rotateSpeed = 70;
            spawnRate = 2.3f;

        }
        if (elapsedSeconds > 153f)
        {

            shrinkSpeed = 6.5f;


            rotateSpeed = -90;
            spawnRate = 2.3f;

        }

        if (elapsedSeconds > 160f)
        {

            shrinkSpeed = 6.5f;


            rotateSpeed = 30;
            spawnRate = 2.3f;

        }

        if (elapsedSeconds > 166f)
        {

            rotateSpeed--;
            spawnRate = 0f;
            if (rotateSpeed <= 30)
            {
                rotateSpeed = 30;
            }
        }
        if (elapsedSeconds == maxTime)
        {

            PlayerPrefs.SetFloat("CGM", 1);
            SceneManager.LoadScene("HardcoreEnd");

        }


    }



}