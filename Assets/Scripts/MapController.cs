using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public RouteEventController routeEventController;
    public int currentCityID;
    public List<Route> routes;

    
    public void Travel(City comeTo)
    {
        foreach (Route route in routes)
        {
            if(route.city1.cityName == Database.GetCity(currentCityID).cityName || route.city2.cityName == Database.GetCity(currentCityID).cityName)
            {
                if(comeTo.cityName == route.city1.cityName && route.city2.cityName == Database.GetCity(currentCityID).cityName || comeTo.cityName == route.city2.cityName && route.city1.cityName == Database.GetCity(currentCityID).cityName)
                {
                    Debug.Log("before travel" + currentCityID);
                    route.Travel(Database.GetCity(currentCityID));
                    route.InitializeEvent();
                }
            }
        }
    }
}
