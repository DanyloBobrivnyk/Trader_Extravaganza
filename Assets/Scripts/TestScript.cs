﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class TestScript : MonoBehaviour
{
    // [SerializeField] private HeatMapVisual heatMapVisual;
    // public Grid<bool> grid;

    // private float mouseMoveTimer;
    // private float mouseMoveTimerMax = .01f;

    // void Start()
    // {
    //     grid = new Grid<bool>(30, 100, 3f, new Vector3(-1,-1,0));

    //     //heatMapVisual.SetGrid(grid);
    // }

    // private void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     { 
    //         //int value = grid.GetValue(UtilsClass.GetMouseWorldPosition());
    //         Vector3 pos = UtilsClass.GetMouseWorldPosition();
    //     }
        
    // }

    // private void HandleHeatMapMouseMove()
    // {
    //     mouseMoveTimer -= Time.deltaTime;
    //     if (mouseMoveTimer < 0f)
    //     {
    //         mouseMoveTimer += mouseMoveTimerMax;
    //         int gridValue = grid.GetValue(UtilsClass.GetMouseWorldPosition());
    //         grid.SetValue(UtilsClass.GetMouseWorldPosition(), gridValue + 1);
    //     }
    // }

    // private void HandleClickToModifyGrid()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         grid.SetValue(UtilsClass.GetMouseWorldPosition(), 1);
    //     }
    // }

    // private class HeatMapVisual
    // {

    //     private Grid grid;
    //     private Mesh mesh;

    //     public HeatMapVisual(Grid grid, MeshFilter meshFilter)
    //     {
    //         this.grid = grid;

    //         mesh = new Mesh();
    //         meshFilter.mesh = mesh;

    //         UpdateHeatMapVisual();

    //         grid.OnGridValueChanged += Grid_OnGridValueChanged;
    //     }

    //     private void Grid_OnGridValueChanged(object sender, System.EventArgs e)
    //     {
    //         UpdateHeatMapVisual();
    //     }

    //     public void UpdateHeatMapVisual()
    //     {
    //         Vector3[] vertices;
    //         Vector2[] uv;
    //         int[] triangles;

    //         MeshUtils.CreateEmptyMeshArrays(grid.GetWidth() * grid.GetHeight(), out vertices, out uv, out triangles);

    //         for (int x = 0; x < grid.GetWidth(); x++)
    //         {
    //             for (int y = 0; y < grid.GetHeight(); y++)
    //             {
    //                 int index = x * grid.GetHeight() + y;
    //                 Vector3 baseSize = new Vector3(1, 1) * grid.GetCellSize();
    //                 int gridValue = grid.GetValue(x, y);
    //                 int maxGridValue = 100;
    //                 float gridValueNormalized = Mathf.Clamp01((float)gridValue / maxGridValue);
    //                 Vector2 gridCellUV = new Vector2(gridValueNormalized, 0f);
    //                 MeshUtils.AddToMeshArrays(vertices, uv, triangles, index, grid.GetWorldPosition(x, y) + baseSize * .5f, 0f, baseSize, gridCellUV, gridCellUV);
    //             }
    //         }

    //         mesh.vertices = vertices;
    //         mesh.uv = uv;
    //         mesh.triangles = triangles;
    //     }

    // }
}