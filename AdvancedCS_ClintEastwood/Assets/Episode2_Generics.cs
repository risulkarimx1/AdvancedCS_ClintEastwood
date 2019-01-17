using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Result<T,U> {
    public T Success { get; set; }
    public U Message { get; set; }
}
public class ResultHelper
{
    public static X PrintResult<T,U,X>(Result<T,U> result)
    {
        Debug.Log("Printing Result-----------");
        Debug.Log("Success = " + result.Success);
        Debug.Log("Message = " + result.Message);

        int value = Random.Range(0, 100);
        return (X)Convert.ChangeType(value, typeof(X)); ;
    }
}
public class Episode2_Generics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Result<bool, string> result = new Result<bool, string> { Success = true, Message ="Awesome" };
        var newResult = new Result<int, int> { Success = 0, Message = 404 };
       
        var x = ResultHelper.PrintResult<bool, string, int>(result);
        Debug.Log(x);
    }
}
