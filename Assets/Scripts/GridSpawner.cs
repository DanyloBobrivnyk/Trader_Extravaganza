using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    private Grid<PathNode> grid;

    private void Start()
    {
        RandomizeObjects(grid.GetHeight(), grid.GetWidth());
    }

    public void RandomizeObjects(int height, int width)
    {
        int objSum = (height*width)/4;

        for(int i = 0; i < objSum; i++)
        {
            grid.GetGridObject(Random.RandomRange(1, height), Random.RandomRange(1, width)).isWalkable = false;
        }
    }
}
