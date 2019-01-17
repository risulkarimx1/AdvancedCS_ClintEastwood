using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void BroadCastShowDelegate(object sender,BoardCastEventArgs eventArgs);
public class BoardCastEventArgs: EventArgs
{
    public int Time { get; set; }
    public string ChannelName { get; set; }
}
class BraoadCaster
{

    public event BroadCastShowDelegate broadCasterEvent;
    public void ShowNewsAt8()
    {
        Debug.Log("News at 8 broad cast");
        broadCasterEvent(this,new BoardCastEventArgs() { Time=8,ChannelName="Channel i"});
    }
    public void ShowNewsAt12()
    {
        Debug.Log("News at 12 broad cast");
        broadCasterEvent(this, new BoardCastEventArgs() { Time = 12, ChannelName = "ATN Bangla" });
    }
}
class TV_Viewer
{
    private string _name;
    private BraoadCaster _broadCaster;
    public TV_Viewer(string name, BraoadCaster broadCaster)
    {
        this._name = name;
        this._broadCaster = broadCaster;

        _broadCaster.broadCasterEvent += (object sender,BoardCastEventArgs args) => 
        {
            Debug.Log(name + " is seeing news at "+args.Time +" in the channel: "+args.ChannelName);
        };
    }
}
public class E8_EventServices : MonoBehaviour
{
    void Start()
    {
        BraoadCaster bc = new BraoadCaster();
        TV_Viewer viewer = new TV_Viewer("Bob", bc);
        bc.ShowNewsAt12();
    }
}
