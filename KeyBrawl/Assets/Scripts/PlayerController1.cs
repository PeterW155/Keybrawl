using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;

    public Transform shootingPoint;
    public GameObject bulletPrefab;

    
    public KeyCode[] inputs;
    public KeyManager keyManager;

    public float speed;
    
    public int health;
    
    public TMP_Text display;

    float x;
    float y;

    private int ammo = 0;
    public int maxAmmo;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        display.text = inputs[4].ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        x = 0.0f;
        y = 0.0f;
        if (Input.GetKey(inputs[0]))
        {
            x -= 1.0f;
            
        }
        if (Input.GetKey(inputs[1]))
        {
            y -= 1.0f;
            
        }
        if (Input.GetKey(inputs[2]))
        {
            x += 1.0f;
            
        }
        if (Input.GetKey(inputs[3]))
        {
            y += 1.0f;
            
        }
        if (Input.GetKeyDown(inputs[4]))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            Debug.Log("Pressed " + inputs[4].ToString());
            ammo = ammo + 1;
            if(ammo >= maxAmmo)
            {
                inputs[4] = keyManager.GetNewKey(inputs[4]);
                ammo = 0;
            }
            display.text = inputs[4].ToString();
        }

        moveDelta = new Vector3(x, y, 0);
        transform.Translate(moveDelta * Time.deltaTime * speed);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("A player died");
        Destroy(this.gameObject);
    }
}
