using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardRouteEvent : MonoBehaviour
{
    public List<Action> functions = new List<Action>();
    
    public static void Hard_RemoveGold()
    {
        Debug.Log("Gold Removed");
    }

    public static void Hard_NoEvent()
    {
        Debug.Log("Hard and no event.");
    }

    public List<Action> GetList()
    {
        return functions;
    }
}
