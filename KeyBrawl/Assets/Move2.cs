using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move2 : MonoBehaviour
{

    private void Update()
    {
        Flip();
    }

    void Flip()
    {
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            transform.Rotate(0, 180, 0);
        }
    }
}
