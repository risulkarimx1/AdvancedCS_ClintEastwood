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

        //var t5 = Task.Factory.StartNew(() => GetDataFromServer("t5", 2102))
        //    .ContinueWith((prevTask) => GetDataFromServer("x1", 1343))
        //    .ContinueWith((prevTask) => GetDataFromServer("x2", 1415))
        //    .ContinueWith((prevTask) => GetDataFromServer("x3", 4131))
        //    .ContinueWith((prevTask) => GetDataFromServer("x4", 1533));



        var t1 = Task.Factory.StartNew(() => GetDataFromServer("t1", 8193));
        var t2 = Task.Factory.StartNew(() => GetDataFromServer("t2", 3245));
        var t3 = Task.Factory.StartNew(() => GetDataFromServer("t3", 4545));
        var t4 = Task.Factory.StartNew(() => GetDataFromServer("t4", 4614));

        List<Task> taskList = new List<Task> { t1, t2, t3, t4 };
        Task.WaitAll(taskList.ToArray());

        Debug.Log("Done with task 1 to 4");

        var t5 = Task.Factory.StartNew(() => GetDataFromServer("t5", 4354));
        var t6 = Task.Factory.StartNew(() => GetDataFromServer("t6", 4245));

    }
    public void GetDataFromServer(string taskId, int duration)
    {
        Debug.Log($"Starting task {taskId}");
        Thread.Sleep(duration);
        Debug.Log($"Finishing task {taskId}");
    }
}
