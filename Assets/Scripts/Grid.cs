using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid
{
    private int width;
    private int height;
    //Initialized two dimensional array
    private int[,] gridArray;
    private float cellSize;
    //Creating Grid Class object, wich is declareted before 
    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        //Empty array, wich has it's size due to width (x) and height (y), in the future it's gona store 
        //info about tiles. *is it walkable or not etc.*
        gridArray = new int[width, height];

        for(int x=0;x < gridArray.GetLength(0);x++)
        {
            for(int y=0; y< gridArray.GetLength(1); y++)
            {
                UtilsClass.CreateWorldText(gridArray[x,y].ToString(), null, GetWorldPosition(x,y) + new Vector3(cellSize,cellSize)/2, 10,Color.white, 
                    TextAnchor.MiddleCenter);
                //Drawing grid borders
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(x + 1, y), GetWorldPosition(x, y), Color.white, 100f);
            }
        }
       Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
       Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);

    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x,y) * cellSize;
    }
}
