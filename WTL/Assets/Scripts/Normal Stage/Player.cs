using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Player : MonoBehaviour
{
    //public float moveSpeed; //player speed
    public bool ableToMove = true;
    float movement = 0f; //Input of pc
    float screenWidth; //width of phone screen
    ParticleSystem EXPO;

    private void Awake()
    {
        //AdmobManager.instance.RequestBannerAD();
        //ad preloaded
    }

    private void Start()
    {
        Time.timeScale = 1f;
        screenWidth = Screen.width/2;
        EXPO = GetComponent<ParticleSystem>();  
    }

    // Update is called once per frame
    void Update()
    {

        if (ableToMove)
        {
            movement = Input.GetAxisRaw("Horizontal");
            TouchControl();
        }

    }

    private void FixedUpdate()
    {
        float moveSpeed = GameObject.FindWithTag("EnemySpawner").GetComponent<Spawner>().moveSpeed;
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed); //player move mechanic || to change left or right direction, pls remove minus from movespeed
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) //when player counters collision with Enemy tag, the Gameover scene will be loaded.
        {
            ableToMove = false;
            Time.timeScale = 0.0f;
            //Visual effect
            EXPO.Play();

            //if (AdmobSystem.instance.InterPointToGive) //admob plsss
            //{
            //    Time.timeScale = 0.1f;
            //    StartCoroutine(AfterDead());
            //}

            StartCoroutine(AfterDead());
        }

        if (collision.CompareTag("Coin"))
        {
            
        }
    }

    void TouchControl()
    {


        if (Input.touchCount > 0 && ableToMove)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < screenWidth)
            {
                float moveSpeed = GameObject.FindWithTag("EnemySpawner").GetComponent<Spawner>().moveSpeed;
                transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * moveSpeed);
            }

            if (touch.position.x > screenWidth)
            {
                float moveSpeed = GameObject.FindWithTag("EnemySpawner").GetComponent<Spawner>().moveSpeed;
                transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * -moveSpeed);
            }
        }

    }

    IEnumerator AfterDead()
    {

        
        float endDeath = Time.realtimeSinceStartup + 1f;
        while (Time.realtimeSinceStartup < endDeath)
        {
            
            yield return 0;
            
        }
        
        SceneManager.LoadScene("GameOver");
    }
}