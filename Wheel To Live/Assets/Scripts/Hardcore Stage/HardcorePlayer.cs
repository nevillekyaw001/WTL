using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class HardcorePlayer : MonoBehaviour
{
    public float moveSpeed = 600f; //player speed
    public bool ableToMove = true;
    float movement = 0f; //Input of pc
    float screenWidth; //width of phone screen
    

    ParticleSystem EXPO;

    private void Awake()
    {
        //AdmobManager.instance.RequestBannerAD();
    }

    private void Start()
    {
        Time.timeScale = 1f;
        screenWidth = Screen.width / 2;
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
            reverseRotator.instance.DeadMusic();
            if (AdmobManager.instance.InterPointToGive)
            {
                Time.timeScale = 0.1f;
                StartCoroutine(AfterDead());
            }


        }
    }

    void TouchControl()
    {


        if (Input.touchCount > 0 && ableToMove)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < screenWidth)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * moveSpeed);
            }

            if (touch.position.x > screenWidth)
            {
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
        SceneManager.LoadScene("HardcoreEnd");
    }
}