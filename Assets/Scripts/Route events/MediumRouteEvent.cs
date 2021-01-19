using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumRouteEvent : MonoBehaviour
{
    public List<Action> functions = new List<Action>();
    public static void Medium_AddGold()
    {
        Debug.Log("Medium addGold.");
    }

    public static void Medium_RemoveGold()
    {
        Debug.Log("Medium removeGold.");
    }

    public static void Medium_NoEvent()
    {
        Debug.Log("Medium and no event.");
    }

    public List<Action> GetList()
    {
        return functions;
    }
}
