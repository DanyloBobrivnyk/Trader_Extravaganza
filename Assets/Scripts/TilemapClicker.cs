using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapClicker : MonoBehaviour
{
    private Camera mainCamera;
    private Tilemap map;
    public Transform player;
    
    void Start()
    {
        map = GetComponent<Tilemap>();
        mainCamera = Camera.main;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 clickWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

            Vector3Int clickCellPosition = map.WorldToCell(clickWorldPosition);

            player.position = map.CellToWorld(clickCellPosition);

            Debug.Log(player.transform.position);
        }
    }
}
