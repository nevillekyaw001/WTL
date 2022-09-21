using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    //for randomizing backgrounds
    public Sprite[] sprites;
    private int rand;

    //for scrolling
    public float speed = 0.1f;
    public Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0, sprites.Length);
        GetComponent<SpriteRenderer>().sprite = sprites[rand];

        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -6.35)
        {
            transform.position = StartPosition;
        }

    }
}
