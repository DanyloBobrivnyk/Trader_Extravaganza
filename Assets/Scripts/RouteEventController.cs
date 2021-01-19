using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteEventController : MonoBehaviour
{
    private EazyRouteEvent eazy;
    private MediumRouteEvent medium;
    private HardRouteEvent hard;
    private int x;

    public delegate void EventDelegate();
    public EventDelegate eventDelegate;

    public void ImplementEvent(RouteDifficulty difficulty)
    {
        switch (difficulty)
        {
            //wyglada jak zla praktyka !! TO JEST GóWNOKOD !!!
            case RouteDifficulty.EAZY:
                x = UnityEngine.Random.Range(0,3);   
                switch (x)
                {
                    case 0:
                        eventDelegate = EazyRouteEvent.EazyEvent_AddGold;
                    break;
                    
                    case 1:
                        eventDelegate = EazyRouteEvent.EazyEvent_AddMeat;
                    break;
                    
                    case 2:
                        eventDelegate = EazyRouteEvent.EazyEvent_NoEvent;
                    break;
                }
            break;
            case RouteDifficulty.MEDIUM:
                x = UnityEngine.Random.Range(0,3);   
                switch (x)
                {
                    case 0:
                        eventDelegate = MediumRouteEvent.Medium_AddGold;
                    break;
                    
                    case 1:
                        eventDelegate = MediumRouteEvent.Medium_NoEvent;
                    break;
                    
                    case 2:
                        eventDelegate = MediumRouteEvent.Medium_RemoveGold;
                    break;
                }

            break;
            case RouteDifficulty.HARD:
                x = UnityEngine.Random.Range(0,2);   
                switch (x)
                {
                    case 0:
                        eventDelegate = HardRouteEvent.Hard_NoEvent;
                    break;
                    
                    case 1:
                        eventDelegate = HardRouteEvent.Hard_RemoveGold;
                    break;
                }

            break;
        }
        eventDelegate();
    }
    
    // private EventDelegate GetRandomEvent(List<EventHandler> list)
    // {
        
    //     return null;
    // }
}
