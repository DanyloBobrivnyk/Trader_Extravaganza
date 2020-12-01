using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

    public class Database : MonoBehaviour
    {
        private static CitiesDB _citiesDB;
        private static PlayerEquipment _playerEquipment; 
        
        private void Start()
        {
            _citiesDB = Resources.Load<CitiesDB>("Scriptable Objects/Cities Database");
            _playerEquipment = FindObjectOfType<PlayerEquipment>();
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

        public static Sprite GetProductIcon(Product product)
        {
            print(product.productType);
            return Resources.Load<Sprite>($"Sprites/Products/{product.productType}");
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

        public static PlayerEquipment GetPlayerEq()
        {
            return _playerEquipment;
        }
    }