using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCreator : MonoBehaviour
{
    public GameObject TileObject;
    public static TileGrid Grid;

    public bool IsPlacingTower;

    private void Awake()
    {
        Grid = new TileGrid(17, 12, 0.75f);

        for (int x = 0; x < Grid.GridArray.GetLength(0); x++)
        {
            for (int y = 0; y < Grid.GridArray.GetLength(1); y++)
            {
                Grid.GridArray[x, y] = Instantiate(TileObject, Grid.GetWorldPosition(x, y) + new Vector2(Grid.CellSize, Grid.CellSize) * .5f, Quaternion.identity, transform.GetChild(0));
                Grid.GridArray[x, y].name = "Tile: (" + x + ", " + y + ")";

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
