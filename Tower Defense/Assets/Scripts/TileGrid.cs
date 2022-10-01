using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    private int width;
    private int height;
    private float CellSize;
    private int[,] GridArray;

    public TileGrid(int width, int height, float CellSize, GameObject TilePrefab)
    {
        this.width = width;
        this.height = height;
        this.CellSize = CellSize;

        GridArray = new int[width, height];

        for (int x = 0; x < GridArray.GetLength(0); x++)
        {
            for (int y = 0; x < GridArray.GetLength(1); y++)
            {
                Instantiate(TilePrefab, GetWorldPosition(x,y), Quaternion.identity);
            }
        }
    }

    private Vector2 GetWorldPosition(int x, int y)
    {
        return new Vector2(x, y) * CellSize;
    }
}
