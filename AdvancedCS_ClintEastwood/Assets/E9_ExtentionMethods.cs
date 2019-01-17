using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
public static class PersonExtention
{
    public static int SayHello(this PersonX person,int age)
    {
        Debug.Log($"Name of the person {person} says hello with age {age}");
        return 212;
    }
}
public class E9_ExtentionMethods : MonoBehaviour
{
    void Start()
    {
        var p = new Person { Name = "John",Age = 15};
        //int x = p.SayHello(99);
        //Debug.Log(x);
    }
}
