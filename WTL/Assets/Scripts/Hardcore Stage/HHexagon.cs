using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HHexagon : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 20f;


    }

    // Update is called once per frame
    void Update()
    {

        float SSpeed = GameObject.FindWithTag("HardcoreSpawner").GetComponent<HardcoreSpawner>().shrinkSpeed;
        transform.localScale -= Vector3.one * SSpeed * Time.deltaTime;

        if (transform.localScale.x < 0.05f)
        {
            Destroy(gameObject);
            

        }

    }
}
