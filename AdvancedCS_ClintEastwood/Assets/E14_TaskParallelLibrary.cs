using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class E14_TaskParallelLibrary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var t1 = Task.Factory.StartNew(() => GetDataFromServer("x1", 2454));
        var t2 = Task.Factory.StartNew(() => GetDataFromServer("x2", 2344));
        var t3 = Task.Factory.StartNew(() => GetDataFromServer("x3", 1354));
        var t4 = Task.Factory.StartNew(() => GetDataFromServer("x4", 5624));

    }
    public void GetDataFromServer(string taskId, int duration)
    {
        Debug.Log($"Starting task {taskId}");
        Thread.Sleep(duration);
        Debug.Log($"Finishing task {taskId}");
    }
}
