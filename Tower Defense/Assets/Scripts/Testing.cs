using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        TileGrid grid = new TileGrid(4, 2, 10f, prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
