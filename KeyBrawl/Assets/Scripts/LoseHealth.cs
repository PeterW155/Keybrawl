using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHealth : MonoBehaviour
{
    public int sub = 1;
    public float duration = 10000f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        PlayerController1 stats = player.GetComponent<PlayerController1>();
        stats.health -= sub;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(duration);
        stats.health /= sub;
        Destroy(gameObject);
    }
}
