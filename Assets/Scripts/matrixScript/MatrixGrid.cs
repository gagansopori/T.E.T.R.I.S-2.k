using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixGrid {

    public static int row = 10;
    public static int column = 20;

    public static Transform[,] grid = new Transform[row, column];


    /*We create a Vector2 named Round Vector, 
    which will return the vector with coordinates
    Rounded off to nearest integer*/
    public static Vector2 RoundVector(Vector2 v)
    {
        return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));             //Mathf.Round will round-off the number to nearest integer

    }

    public static bool IsInsideBorder(Vector2 pos)
    {
        return((int)pos.x >= 0 && (int)pos.x < row && (int)pos.y >= 0);

    }
	
    public static void DeleteRow(int y)
    {
        for (int x = 0; x < row; ++x)
        {
            GameObject.Destroy(grid[x, y].gameObject);
            grid[x, y] = null;
        }
    }
	
    public static void DecreaseRow(int y)
    {
        for(int x = 0; x < row; ++x)
        {
            if(grid[x,y] != null)
            {
                grid[x, y - 1] = grid[x,y];
                grid[x, y] = null;

                grid[x, y - 1].position += new Vector3(0, -1, 0);


            }
        }
    }
    
    public static void DecreaseRowsAbove(int y)
    {
        for(int i = 0; i< column; ++i)
        {
            DecreaseRow(i);
        }
    }

    public static bool IsRowFull(int y)
    {
        for (int x = 0; x < row; ++x)
        {
            if (grid[x, y] == null)
                return false;
        }
        return true;
    }

    public static void DestroyCompleteRow()
    {
        for (int y=0; y< column;++y)
        {
            if (IsRowFull(y))
            {
                DeleteRow(y);
                DecreaseRowsAbove(y + 1);
                --y;

            }

        }
    }
}
