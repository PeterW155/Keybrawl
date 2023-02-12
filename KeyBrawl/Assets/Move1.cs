using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move1 : MonoBehaviour
{

    private void Update()
    {
        Flip();
    }

    void Flip()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            transform.Rotate(0, 180, 0);
        }
    }
}
