using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        TileGrid grid = new TileGrid(17, 12, 0.75f);

        for (int x = 0; x < grid.GridArray.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GridArray.GetLength(1); y++)
            {
                grid.GridArray[x, y] = Instantiate(prefab, grid.GetWorldPosition(x, y) + new Vector2(grid.CellSize, grid.CellSize) * .5f, Quaternion.identity);

                //Instantiate(TilePrefab, GetWorldPosition(x,y), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
