using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector3 targetPosition = new Vector2(0f, 0f);
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToward();
        DestroyObject();
    }

    void MoveToward()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, CoinSpawner.instance.moveSpeed * Time.deltaTime);
    }

    void DestroyObject()
    {
        if(transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            PointSystem.instance.AddCoin(1);
            PointSystem.UpdateCoins();
        }
    }
}
