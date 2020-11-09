using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapSpawner : MonoBehaviour
{
    private int spawnRadius = 1;
    [SerializeField]
    private int checkRadius;
    public int rangeX;
    public int rangeY;
    [SerializeField] 
    private TileBase tileToSet;
    [SerializeField] 
    private TileBase cityTile;
    [SerializeField]
    private Tilemap map;
    private Vector3Int tilemapPosTest = new Vector3Int(5,5,0);
    public TileBase randomTile;
    void Start()
    {

        map = GetComponent<Tilemap>();
            
        //map.CompressBounds();

        for(int i = 0; i < 5;)
        {
            //-8 8  -9 9 HEx              -14 14 7 -7 Square
            Vector3Int citySpawnPos = new Vector3Int(Random.RandomRange(-rangeX, rangeX),Random.RandomRange(-rangeY, rangeY), 0);
            if(CheckNeighbourTiles(citySpawnPos) == false)
            {
                SpawnCity(citySpawnPos);
                i++;
            }
            else
            {
                continue;
            }
        }
        //map.FloodFill(tilemapPosCenter, tileToSet);
        FillWithRandomTiles(rangeX,rangeY);
    }
    private bool CheckNeighbourTiles(Vector3Int coords)
    {
        if(map.GetTile(coords))
        {
            return true;
        }
        for(int x=-checkRadius; x <=checkRadius; x++)
        {
            for(int y=-checkRadius; y<=checkRadius; y++)
            {
                if(map.GetTile(coords + new Vector3Int(x,y,0)))
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
        }
        return false;
    }
    private void SpawnCity(Vector3Int coords)
    {
        for(int x=-spawnRadius; x <=spawnRadius; x++)
        {
            for(int y=-spawnRadius; y<=spawnRadius; y++)
            {
                map.SetTile(coords + new Vector3Int(x,y,0), tileToSet);
            }
        }
        map.SetTile(coords, cityTile);
    } 
    private void FillWithRandomTiles(int rangeX, int rangeY)
    {
            for(int x=-rangeX;x<=rangeX;x++)
            {
                for(int y=-rangeY;y<=rangeY;y++)
                {
                    if(map.GetTile(new Vector3Int(x,y,0)))
                    {
                        continue;
                    }
                    else
                    {
                        map.SetTile(new Vector3Int(x,y,0),randomTile);
                    }
                }
            }
    }
}
