using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E13_OptionalParameters : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SayMyName_and_Age("risul ");
        SayMyName_and_Age(fName: "karim", age: 902);
    }

    public void SayMyName_and_Age(string fName="default fname",string lName="defaul lname",int age=0)
    {
        Debug.Log($"First {fName} Last Name {lName} & age is {age}");
    }
}
