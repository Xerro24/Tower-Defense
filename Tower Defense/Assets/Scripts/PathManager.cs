using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public Vector2 PathStart;
    public Vector2 PathEnd;

    // Start is called before the first frame update
    void Start()
    {
        GridCreator.Grid.GridArray[(int)PathStart.x, (int)PathStart.y].GetComponent<Tiles>().IsStartTile = true;
        GridCreator.Grid.GridArray[(int)PathEnd.x, (int)PathEnd.y].GetComponent<Tiles>().IsEndTile = true;
    }

    private void Awake()
    {
        GridCreator.Grid.GridArray[(int)PathStart.x, (int)PathStart.y].GetComponent<Tiles>().IsStartTile = true;
        GridCreator.Grid.GridArray[(int)PathEnd.x, (int)PathEnd.y].GetComponent<Tiles>().IsEndTile = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
