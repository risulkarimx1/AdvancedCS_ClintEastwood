using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class SampleAttribute : Attribute
{

}
[Sample]
public class AttributeTester
{

}
public class Epi4_5_Attributes_Reflection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.GetCustomAttributes(typeof(SampleAttribute), true).Length > 0
                    select t;
        foreach (var t in types)
        {
            Debug.Log(t);
        }
    }
}
