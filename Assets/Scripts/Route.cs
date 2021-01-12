﻿using System.Collections;
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
				roadImage.color = Color.green;
			break;
			
			case RouteDifficulty.MEDIUM:
				roadImage.color = Color.white;
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
		}
		else
		{
			mapController.currentCityID = Database.GetID(city1);
		}
		Debug.Log(mapController.currentCityID);
	}
	
}
public enum RouteDifficulty
{
	EAZY,
	MEDIUM,
	HARD
}