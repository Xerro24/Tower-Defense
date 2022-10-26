using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCreatorObject
{
    public Vector2 Direction;
    public int Magnitiude;
    public Vector2 StartTile;

    public PathCreatorObject(Vector2 Direction, int Magnitiude, Vector2 StartTile)
    {
        this.Direction = Direction;
        this.Magnitiude = Magnitiude;
        this.StartTile = StartTile;
    }

    public PathCreatorObject()
    {
        this.Direction = Vector2.zero;
        this.Magnitiude = 0;
        this.StartTile = Vector2.zero;
    }
}
