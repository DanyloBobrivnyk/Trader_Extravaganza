using System;
using System.Collections.Generic;
using UnityEngine;

namespace Database
{
    public class CitiesDatabase : MonoBehaviour
    {
        [SerializeField] private static CitiesDB _citiesDB;

        private void Start()
        {
            _citiesDB = Resources.Load<CitiesDB>("Scriptable Objects/Cities Database");
        }

        public static List<City> GetCities()
        {
            return _citiesDB.Database;
        }

        // ID is index of City in database
        public static City GetCity(int id)
        {
            return _citiesDB.Database[id];
        }

        public static List<string> GetCityPapersMessages(int id)
        {
            List<string> messages = new List<string>();
            foreach (var paper in _citiesDB.Database[id].papers)
            {
                messages.Add(paper.message);
            }

            return messages;
        }
    }
}