using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

[AttributeUsage(AttributeTargets.Class)]
class UtilityClassAttributeAttribute : Attribute
{

}
[AttributeUsage(AttributeTargets.Method)]
class TranslateMethodAttribute : Attribute
{

}

class ServerClass
{
    public bool isConnected { get; set; }
    public void SetConnection()
    {
    }
    public void Disconnect()
    {
    }
}
[UtilityClassAttribute]
class Utility
{
    public string UtiName { get; set; }
    public int timeDuration { get; set; }
    int xField = 0;
    public void GetVersion()
    {
        Debug.Log("Version is X5");
    }
    [TranslateMethod]
    public void Translate()
    {
        Debug.Log("Translating German to English");
    }
}
public class E5_ReflectionAttributes : MonoBehaviour
{   
    void Start()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<UtilityClassAttributeAttribute>().Count() > 0);
        foreach (var type in types) {
            Debug.Log("Type is: " + type);
            
            var util = Activator.CreateInstance(type);
            util = new Utility { UtiName = "unity name", timeDuration = 60 };
            var methods = type.GetMethods().Where(m => m.GetCustomAttributes<TranslateMethodAttribute>().Count() > 0);
            foreach (var method in methods)
            {
                Debug.Log("Name of method is: "+method.Name);
                method.Invoke(util, null);
            }
        }

    }
}
