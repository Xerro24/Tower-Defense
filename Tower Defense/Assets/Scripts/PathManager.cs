using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public Vector2 PathStart;
    public Vector2 PathEnd;
    public Vector2[] PathEditor;
    [SerializeField] public PathCreatorObject[] Path;

    // Start is called before the first frame update
    void Start()
    {
        //print("test");

        Path = new PathCreatorObject[PathEditor.Length];

        GridCreator.Grid.GridArray[(int)PathStart.x, (int)PathStart.y].GetComponent<Tiles>().IsStartTile = true;
        GridCreator.Grid.GridArray[(int)PathEnd.x, (int)PathEnd.y].GetComponent<Tiles>().IsEndTile = true;

        for (int i = 0; i < Path.Length; i++)
        {
            Path[i] = new PathCreatorObject();
        }

        for (int i = 0; i < PathEditor.Length; i++)
        {
            print(i);

            if (PathEditor[i].x == 1)
            {
                Path[i].Direction = Vector2.right;
            }

            else if (PathEditor[i].x == -1)
            {
                Path[i].Direction = Vector2.left;
            }
            else if (PathEditor[i].x == 2)
            {
                Path[i].Direction = Vector2.up;
            }
            else if (PathEditor[i].x == -2)
            {
                Path[i].Direction = Vector2.down;
            }

            Path[i].Magnitiude = (int)PathEditor[i].y;

            if (i == 0)
            {
                Path[i].StartTile = PathStart;

                if (Path[i].Direction == Vector2.right)
                    Path[i].StartTile = new Vector2(PathStart.x + Path[i].Magnitiude, PathStart.y);
                else if (Path[i].Direction == Vector2.left)
                    Path[i].StartTile = new Vector2(PathStart.x - Path[i].Magnitiude, PathStart.y);
                else if (Path[i].Direction == Vector2.up)
                    Path[i].StartTile = new Vector2(PathStart.x, PathStart.y + Path[i].Magnitiude);
                else if (Path[i].Direction == Vector2.down)
                    Path[i].StartTile = new Vector2(PathStart.x, PathStart.y - Path[i].Magnitiude);
            }

            else
            {
                //print(Path[i].Direction);
                if (Path[i].Direction == Vector2.right)
                    Path[i].StartTile = new Vector2 (Path[i-1].StartTile.x + Path[i].Magnitiude, Path[i-1].StartTile.y);
                else if (Path[i].Direction == Vector2.left)
                    Path[i].StartTile = new Vector2(Path[i - 1].StartTile.x - Path[i].Magnitiude, Path[i - 1].StartTile.y);
                else if (Path[i].Direction == Vector2.up)
                    Path[i].StartTile = new Vector2(Path[i - 1].StartTile.x, Path[i - 1].StartTile.y + Path[i].Magnitiude);
                else if (Path[i].Direction == Vector2.down)
                    Path[i].StartTile = new Vector2(Path[i - 1].StartTile.x , Path[i - 1].StartTile.y - Path[i].Magnitiude);
            }
        }

        for (int i = 0; i < Path.Length; i++)
        {
            print(Path[i].StartTile);
        }

        if (Path[Path.Length - 1].StartTile == PathEnd)
            print("bingus");
        
        for (int i = 0; i < PathEditor.Length; i++)
        {
            if (PathEditor[i].x == 1)
            {
                for (int j = 1; j <= PathEditor[j].y; j++)
                {
                    GridCreator.Grid.GridArray[(int)PathEnd.x, (int)PathEnd.y].GetComponent<Tiles>().IsEndTile = true;

                }
            }

            else if (PathEditor[i].x == -1)
            {
                for (int j = 1; j <= PathEditor[j].y; j++)
                {
                    GridCreator.Grid.GridArray[(int)PathEnd.x, (int)PathEnd.y].GetComponent<Tiles>().IsEndTile = true;

                }
            }
            else if (PathEditor[i].x == 2)
            {
                for (int j = 1; j <= PathEditor[j].y; j++)
                {
                    GridCreator.Grid.GridArray[(int)PathEnd.x, (int)PathEnd.y].GetComponent<Tiles>().IsEndTile = true;

                }
            }
            else if (PathEditor[i].x == -2)
            {
                for (int j = 1; j < PathEditor[j].y; j++)
                {
                    GridCreator.Grid.GridArray[(int)PathStart.x, (int)PathStart.y-j].GetComponent<Tiles>().IsPath = true;

                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
