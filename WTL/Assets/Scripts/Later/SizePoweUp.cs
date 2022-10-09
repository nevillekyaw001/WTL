using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePoweUp : MonoBehaviour
{
    public GameObject pickUpEffect;

    float duration = 10f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( PickUp(other));
        }
    }

    IEnumerator PickUp(Collider2D player)
    {
        //Instantiate(pickUpEffect, transform.position, transform.rotation);

        Player PlayerStat = player.GetComponent<Player>();

        player.transform.localScale /= 2.5f;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;

        yield return new WaitForSeconds(duration);

        player.transform.localScale *= 2.5f;

        Destroy(gameObject);
    }

}
