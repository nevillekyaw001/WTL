using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverseRotator : MonoBehaviour
{
    public static reverseRotator instance;
    [SerializeField] AudioSource audioS;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audioS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        turn();


    }

    public void turn()
    {
        float RS = GameObject.FindWithTag("HardcoreSpawner").GetComponent<HardcoreSpawner>().rotateSpeed;
        transform.Rotate(Vector3.back * Time.deltaTime * RS); // script for rotating camera
    }

    public void DeadMusic()
    {
        audioS.Pause();
    }

    

}
