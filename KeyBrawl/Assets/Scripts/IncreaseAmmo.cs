using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController1>().maxAmmo = collision.gameObject.GetComponent<PlayerController1>().maxAmmo + 1;

        }
        Destroy(this.gameObject);
    }
}
