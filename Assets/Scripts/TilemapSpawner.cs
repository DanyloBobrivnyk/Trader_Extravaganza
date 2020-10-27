using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapSpawner : MonoBehaviour
{
    public int radius = 1;
    public TileBase tileToSet;
    public TileBase cityTile;
    private Tilemap map;
    //[SerializeField]
    //public Tilemap cityMap;
    private Camera mainCamera;
    private Vector3Int tilemapPosCenter = Vector3Int.zero;
    void Start()
    {

        map = GetComponent<Tilemap>();
            
        map.CompressBounds();
        mainCamera = Camera.main;

        for(int i = 0; i < 5;)
        {
            //-8 8  -9 9 
            Vector3Int citySpawnPos = new Vector3Int(Random.RandomRange(-13, 13),Random.RandomRange(-7, 7), 0);
            if(!map.GetSprite(citySpawnPos))
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
    }

    private void SpawnCity(Vector3Int coords)
    {
        map.SetTile(coords, cityTile);
        
        for(int x=-radius; x <=radius; x++)
        {
            for(int y=-radius; x<=radius; y++)
            {
                map.SetTile(coords + new Vector3Int(x,y,0), tileToSet);
            }
        }
    } 
}
