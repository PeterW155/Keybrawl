using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //public Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;

    public Transform shootingPoint;
    public GameObject bulletPrefab;

    //public Key[] inputs;
    public KeyCode[] inputs;
    public KeyManager keyManager;

    public float speed;
    //public float speedLimiter;
    public int health;
    //public float inputHorizonatl;
    //public float inputVertical;

    float x;
    float y;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        inputs = new KeyCode[5];
    }

    // Start is called before the first frame update
    void Start()
    {
        inputs[0] = KeyCode.LeftArrow;
        inputs[1] = KeyCode.DownArrow;
        inputs[2] = KeyCode.RightArrow;
        inputs[3] = KeyCode.UpArrow;
        inputs[4] = KeyCode.P;


        /*inputs[0] = test;
        inputs[0].key = KeyCode.A;
        inputs[0].keyName = "A";
        inputs[1].key = KeyCode.S;
        inputs[1].keyName = "S";
        inputs[2].key = KeyCode.D;
        inputs[2].keyName = "D";
        inputs[3].key = KeyCode.W;
        inputs[3].keyName = "W";

        inputs[4].key = KeyCode.Q;
        inputs[4].keyName = "Q";*/
    }

    // Update is called once per frame
    void Update()
    {
        x = 0.0f;
        y = 0.0f;
        if (Input.GetKey(inputs[0]))
        {
            x -= 1.0f;
            //Debug.Log("Pressed "+ inputs[0].ToString());
        }
        if (Input.GetKey(inputs[1]))
        {
            y -= 1.0f;
            //Debug.Log("Pressed " + inputs[1].ToString());
        }
        if (Input.GetKey(inputs[2]))
        {
            x += 1.0f;
            //Debug.Log("Pressed " + inputs[2].ToString());
        }
        if (Input.GetKey(inputs[3]))
        {
            y += 1.0f;
            //Debug.Log("Pressed " + inputs[3].ToString());
        }
        if (Input.GetKeyDown(inputs[4]))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            Debug.Log("Pressed " + inputs[4].ToString());
            inputs[4] = keyManager.GetNewKey(inputs[4]);
        }

        moveDelta = new Vector3(x, y, 0);
        transform.Translate(moveDelta * Time.deltaTime * speed);
    }
}
