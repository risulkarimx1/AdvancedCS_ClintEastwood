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
        //var t1 = new Task(() => GetDataFromServer("t1", 1034));
        //var t2 = new Task(() => GetDataFromServer("t2", 3431));
        //var t3 = new Task(() => GetDataFromServer("t3", 1234));
        //var t4 = new Task(() => GetDataFromServer("t4", 1353));

        var t5 = Task.Factory.StartNew(() => GetDataFromServer("t5", 2102))
            .ContinueWith((prevTask) => GetDataFromServer("x1", 1343))
            .ContinueWith((prevTask) => GetDataFromServer("x2", 1415))
            .ContinueWith((prevTask) => GetDataFromServer("x3", 4131))
            .ContinueWith((prevTask) => GetDataFromServer("x4", 1533));



        var t6 = Task.Factory.StartNew(()=>GetDataFromServer("t6",8193));




    }
    public void GetDataFromServer(string taskId, int duration)
    {
        Debug.Log($"Starting task {taskId}");
        Thread.Sleep(duration);
        Debug.Log($"Finishing task {taskId}");
    }
}
