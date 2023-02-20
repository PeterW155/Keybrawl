using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowerMovement : MonoBehaviour
{
    public float multiplier = 0.5f;
    public float duration = 6f;

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
        stats.speed *= multiplier;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(duration);
        stats.speed /= multiplier;
        Destroy(gameObject);
    }
}
