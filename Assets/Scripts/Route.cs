using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Route : MonoBehaviour
{
	public MapController mapController;
	//public Transform playerPosition;
	public City city1;
	public City city2;
	[SerializeField] private Image roadImage;
	public RouteDifficulty difficulty;

	private void Start() {
		switch (difficulty)
		{
			case RouteDifficulty.EAZY:
				roadImage.color = Color.blue;
			break;
			
			case RouteDifficulty.MEDIUM:
				roadImage.color = Color.yellow;
			break;
			
			case RouteDifficulty.HARD:
				roadImage.color = Color.red;
			break;
		}
	}

	public void Travel(City comeFrom)
	{
		if(city1.cityName == comeFrom.cityName)
		{
			mapController.currentCityID = Database.GetID(city2);
			Debug.Log("After travel ID:" + mapController.currentCityID);
		}
		else if(city2.cityName == comeFrom.cityName)
		{
			mapController.currentCityID = Database.GetID(city1);
			Debug.Log("After travel ID:" + mapController.currentCityID);
		}

	}
	public void InitializeEvent()
	{
		mapController.routeEventController.ImplementEvent(difficulty);
	}

}
public enum RouteDifficulty
{
	EAZY,
	MEDIUM,
	HARD
}