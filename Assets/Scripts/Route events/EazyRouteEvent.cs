using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EazyRouteEvent : MonoBehaviour
{
    public List<RouteEventController.EventDelegate> functions = new List<RouteEventController.EventDelegate>();
    
    private void Start() {
        functions.Add(EazyEvent_AddGold);
        functions.Add(EazyEvent_AddMeat);

    }
    public static void EazyEvent_AddGold()
    {
        Debug.Log("Gold Added");
    }

    public static void EazyEvent_AddMeat()
    {
        Debug.Log("Meat Added");
    }

    public static void EazyEvent_NoEvent()
    {
        Debug.Log("Everything was fine.");
    }
    
    public List<RouteEventController.EventDelegate> GetList()
    {
        return functions;
    }
}
