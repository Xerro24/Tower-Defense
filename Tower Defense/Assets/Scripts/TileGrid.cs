using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid
{
    public int width;
    public int height;
    public float CellSize;
    public GameObject[,] GridArray;

    public TileGrid(int width, int height, float CellSize, GameObject TilePrefab)
    {
        this.width = width;
        this.height = height;
        this.CellSize = CellSize;

        GridArray = new GameObject[width, height];

        for (int x = 0; x < GridArray.GetLength(0); x++)
        {
            for (int y = 0; y < GridArray.GetLength(1); y++)
            {
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.red, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.red, 100f);
                //Instantiate(TilePrefab, GetWorldPosition(x,y), Quaternion.identity);
            }
        }

        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.red, 100f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.red, 100f);
    }

    public Vector2 GetWorldPosition(int x, int y)
    {
        return new Vector2(x, y) * CellSize;
    }
}
