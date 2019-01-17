using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E6_ReturningDelegate : MonoBehaviour
{
    public delegate void MathOps(int input);
    public void Square(int input)
    {
        int output = input * input;
        Debug.Log("Square = "+ output);
    }
    public void Cube(int input)
    {
        int output = input * input * input;
        Debug.Log("Square = " + output);
    }
    private void Start()
    {
        MathOps mathops = Square;
        mathops += Cube;
        mathops(4);
    }

    public void PrintNameMethod()
    {
        Debug.Log("Print the name of the class");
    }
    private delegate void PrintNameDelegate();
    
    private PrintNameDelegate GiveMyDelegate()
    {
        PrintNameDelegate pnd = PrintNameMethod;
        return pnd;
    }
}
