using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Key : MonoBehaviour
{
    public KeyCode key;
    public string keyName;
    public bool isOpen;
}

public class KeyManager : MonoBehaviour
{

    public Key[] keys;
    public KeyCode[] keyCodes;
    private KeyCode[] usedKeys;

    private void Awake()
    {
        keys = new Key[30];
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


        /*keys[1].key = KeyCode.Q;
        keys[0].keyName = "Q";
        keys[0].isOpen = false;

        keys[1].key = KeyCode.W;
        keys[1].keyName = "W";
        keys[1].isOpen = false;

        keys[2].key = KeyCode.E;
        keys[2].keyName = "E";
        keys[2].isOpen = true;

        keys[3].key = KeyCode.R;
        keys[3].keyName = "R";
        keys[3].isOpen = true;

        keys[4].key = KeyCode.T;
        keys[4].keyName = "T";
        keys[4].isOpen = true;

        keys[5].key = KeyCode.Y;
        keys[5].keyName = "Y";
        keys[5].isOpen = true;

        keys[6].key = KeyCode.U;
        keys[6].keyName = "U";
        keys[6].isOpen = true;

        keys[7].key = KeyCode.I;
        keys[7].keyName = "I";
        keys[7].isOpen = true;

        keys[8].key = KeyCode.O;
        keys[8].keyName = "O";
        keys[8].isOpen = true;

        keys[9].key = KeyCode.P;
        keys[9].keyName = "P";
        keys[9].isOpen = false;

        keys[10].key = KeyCode.A;
        keys[10].keyName = "A";
        keys[10].isOpen = false;

        keys[11].key = KeyCode.S;
        keys[11].keyName = "S";
        keys[11].isOpen = false;

        keys[12].key = KeyCode.D;
        keys[12].keyName = "D";
        keys[12].isOpen = false;

        keys[13].key = KeyCode.F;
        keys[13].keyName = "F";
        keys[13].isOpen = true;

        keys[14].key = KeyCode.G;
        keys[14].keyName = "G";
        keys[14].isOpen = true;

        keys[15].key = KeyCode.H;
        keys[15].keyName = "H";
        keys[15].isOpen = true;

        keys[16].key = KeyCode.J;
        keys[16].keyName = "J";
        keys[16].isOpen = true;

        keys[17].key = KeyCode.K;
        keys[17].keyName = "K";
        keys[17].isOpen = true;

        keys[18].key = KeyCode.L;
        keys[18].keyName = "L";
        keys[18].isOpen = true;

        keys[19].key = KeyCode.Z;
        keys[19].keyName = "Z";
        keys[19].isOpen = true;

        keys[20].key = KeyCode.X;
        keys[20].keyName = "X";
        keys[20].isOpen = true;

        keys[21].key = KeyCode.C;
        keys[21].keyName = "C";
        keys[21].isOpen = true;

        keys[22].key = KeyCode.V;
        keys[22].keyName = "V";
        keys[22].isOpen = true;

        keys[23].key = KeyCode.B;
        keys[23].keyName = "B";
        keys[23].isOpen = true;

        keys[24].key = KeyCode.N;
        keys[24].keyName = "N";
        keys[24].isOpen = true;

        keys[25].key = KeyCode.M;
        keys[25].keyName = "M";
        keys[25].isOpen = true;

        keys[26].key = KeyCode.LeftArrow;
        keys[26].keyName = "<-";
        keys[26].isOpen = false;

        keys[27].key = KeyCode.UpArrow;
        keys[27].keyName = "/\\";
        keys[27].isOpen = false;

        keys[28].key = KeyCode.RightArrow;
        keys[28].keyName = "->";
        keys[29].isOpen = false;

        keys[29].key = KeyCode.DownArrow;
        keys[29].keyName = "\\/";
        keys[29].isOpen = false;

        keys[30].key = KeyCode.Space;
        keys[30].keyName = "Space";
        keys[30].isOpen = true;*/
    }

    // Update is called once per frame
    void Update()
    {
        
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
