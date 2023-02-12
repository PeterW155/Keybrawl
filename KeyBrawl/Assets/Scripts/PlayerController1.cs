using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Key[] inputs;
    public KeyManager keyManager;

    public float speed;
    public float speedLimiter;
    public int health;
    public float inputHorizonatl;
    public float inputVertical;
    private Key test;

    // Start is called before the first frame update
    void Start()
    {
        inputs = new Key[4];

        inputs[0] = test;
        inputs[0].key = KeyCode.A;
        inputs[0].keyName = "A";
        inputs[1].key = KeyCode.S;
        inputs[1].keyName = "S";
        inputs[2].key = KeyCode.D;
        inputs[2].keyName = "D";
        inputs[3].key = KeyCode.W;
        inputs[3].keyName = "W";

        inputs[4].key = KeyCode.Q;
        inputs[4].keyName = "Q";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(inputs[0].key))
        {
            Debug.Log("Pressed 0");
        }
        if (Input.GetKey(inputs[1].key))
        {
            Debug.Log("Pressed 1");
        }
        if (Input.GetKey(inputs[2].key))
        {
            Debug.Log("Pressed 2");
        }
        if (Input.GetKey(inputs[3].key))
        {
            Debug.Log("Pressed 3");
        }
        if (Input.GetKeyDown(inputs[4].key))
        {
            Debug.Log("Pressed " + inputs[4].keyName);
            inputs[4] = keyManager.GetNewKey(inputs[4]);
        }
    }
}
