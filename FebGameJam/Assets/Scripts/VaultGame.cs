using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultGame : InteractableItem
{
    // int for the vault number
    private int vaultNum;
    private float nextActionTime;
    private int[] code;
    private int countDone;

    // Start is called before the first frame update
    void Start()
    {
        vaultNum = 0;
        nextActionTime = 0.0f;
        code = new int[3];
        countDone = 0;

        code[0] = Random.Range(0, 360);
        code[1] = Random.Range(0, 360);
        code[2] = Random.Range(0, 360);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime+=.1f;
                if(vaultNum == 361) { vaultNum = 0; }
                vaultNum++;
                gameObject.transform.Rotate(new Vector3(0, 0, 1));
            }
        }
        else if (Input.GetKey(KeyCode.E))
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime+=.1f;
                if(vaultNum == -1) { vaultNum = 360; }
                vaultNum--;
                gameObject.transform.Rotate(new Vector3(0, 0, -1));
            }
        }

        if(code[countDone] == vaultNum) { countDone++; }

       
    }
}
