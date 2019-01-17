using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E7_Annonymous : MonoBehaviour
{
    delegate float Operation(int input);
    // Start is called before the first frame update
    void Start()
    {
        //Operation op = input => { return input * 2 * 3.1416f; };
        Func<int,int,float> op= (input1,input2) => {
            return input1*input2;
        };
        float x = op(5,20);
        Debug.Log(x);
    }
}
