using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 position;
    [SerializeField] Vector3 center; 
    [SerializeField] float timeToCenter = 10f;
    [SerializeField] Vector3 deadZone;

    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
    }

    // Update is called once per frame
    void Update()
    {
        //float Sspeed = GameObject.FindWithTag("CoinSpawner").GetComponent<CoinSpawner>().shrinkSpeed;
        //transform.localScale -= Vector3.zero * Time.deltaTime;
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, center, timeToCenter * Time.deltaTime);

        if (gameObject.transform.position == Vector3.zero)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
