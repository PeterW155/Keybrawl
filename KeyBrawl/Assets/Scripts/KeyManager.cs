using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyManager : MonoBehaviour
{
    public KeyCode[] keyCodes;
    private KeyCode[] usedKeys;

    private void Awake()
    {
        keyCodes = new KeyCode[31];
        usedKeys = new KeyCode[11];
    }

    // Start is called before the first frame update
    void Start()
    {

        keyCodes[0] = KeyCode.Q;
        keyCodes[1] = KeyCode.W;
        keyCodes[2] = KeyCode.E;
        keyCodes[3] = KeyCode.R;
        keyCodes[4] = KeyCode.T;
        keyCodes[5] = KeyCode.Y;
        keyCodes[6] = KeyCode.U;
        keyCodes[7] = KeyCode.I;
        keyCodes[8] = KeyCode.O;
        keyCodes[9] = KeyCode.P;
        keyCodes[10] = KeyCode.A;
        keyCodes[11] = KeyCode.S;
        keyCodes[12] = KeyCode.D;
        keyCodes[13] = KeyCode.F;
        keyCodes[14] = KeyCode.G;
        keyCodes[15] = KeyCode.H;
        keyCodes[16] = KeyCode.J;
        keyCodes[17] = KeyCode.K;
        keyCodes[18] = KeyCode.L;
        keyCodes[19] = KeyCode.Z;
        keyCodes[20] = KeyCode.X;
        keyCodes[21] = KeyCode.C;
        keyCodes[22] = KeyCode.V;
        keyCodes[23] = KeyCode.B;
        keyCodes[24] = KeyCode.N;
        keyCodes[25] = KeyCode.M;
        keyCodes[26] = KeyCode.LeftArrow;
        keyCodes[27] = KeyCode.RightArrow;
        keyCodes[28] = KeyCode.UpArrow;
        keyCodes[29] = KeyCode.DownArrow;
        keyCodes[30] = KeyCode.Space;

        usedKeys[0] = KeyCode.A;
        usedKeys[1] = KeyCode.S;
        usedKeys[2] = KeyCode.D;
        usedKeys[3] = KeyCode.W;
        usedKeys[4] = KeyCode.Space;
        usedKeys[5] = KeyCode.LeftArrow;
        usedKeys[6] = KeyCode.RightArrow;
        usedKeys[7] = KeyCode.UpArrow;
        usedKeys[8] = KeyCode.DownArrow;
        usedKeys[9] = KeyCode.P;

    }

    public KeyCode GetNewKey(KeyCode current)
    {
        bool cont = true;
        KeyCode ret = KeyCode.LeftAlt;
        while (cont)
        {
            int rand = Random.Range(0, 30);
            int pos = System.Array.IndexOf(usedKeys, keyCodes[rand]);
            if (pos == -1)
            {
                cont = false;
                ret = keyCodes[rand];
                usedKeys[System.Array.IndexOf(usedKeys, current)] = ret;
            }
        }


        return ret;
    }
}
