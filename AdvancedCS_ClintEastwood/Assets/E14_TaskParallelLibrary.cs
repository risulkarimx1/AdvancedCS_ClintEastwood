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
        var task = new Task(() => { GetDataFromServer("x1", 1000); });

    }
    public void GetDataFromServer(string taskId,int duration)
    {
        Debug.Log($"Starting task {taskId}");
        Thread.Sleep(duration);
        Debug.Log($"Finishing task {taskId}");
    }
}
