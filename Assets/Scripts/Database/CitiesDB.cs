using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cities Database", menuName = "Database/Cities Database", order = 1)]
public class CitiesDB : ScriptableObject
{
    public List<City> Database;
}
