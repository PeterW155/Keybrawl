using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    //public Key[] inputs;
    public KeyCode[] inputs;
    public KeyManager keyManager;

    public float speed;
    public float speedLimiter;
    public int health;
    public float inputHorizonatl;
    public float inputVertical;
    private Key test;

    private void Awake()
    {
        inputs = new KeyCode[5];
    }

    // Start is called before the first frame update
    void Start()
    {
        inputs[0] = KeyCode.A;
        inputs[1] = KeyCode.S;
        inputs[2] = KeyCode.D;
        inputs[3] = KeyCode.W;
        inputs[4] = KeyCode.Space;


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
        if (Input.GetKey(inputs[0]))
        {
            Debug.Log("Pressed "+ inputs[0].ToString());
        }
        if (Input.GetKey(inputs[1]))
        {
            Debug.Log("Pressed " + inputs[1].ToString());
        }
        if (Input.GetKey(inputs[2]))
        {
            Debug.Log("Pressed " + inputs[2].ToString());
        }
        if (Input.GetKey(inputs[3]))
        {
            Debug.Log("Pressed " + inputs[3].ToString());
        }
        if (Input.GetKeyDown(inputs[4]))
        {
            Debug.Log("Pressed " + inputs[4].ToString());
            inputs[4] = keyManager.GetNewKey(inputs[4]);
        }
    }
}
