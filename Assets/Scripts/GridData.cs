using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GridData : ScriptableObject
{
    [SerializeField]
    private List<CellData> cells;

    public List<CellData> Cells { get => cells; set => cells = value; }

    public static GridData CreateInstance(int rows, int cols)
    {
        GridData instance = ScriptableObject.CreateInstance<GridData>();
        instance.Cells = new List<CellData>();

        for (int posX = 0; posX < rows; posX++)
        {
            for (int posY = 0; posY < cols; posY++)
            {
                instance.Cells.Add(new CellData(Vector4.zero, new Vector2(posX, posY), null));
            }
        }
        return instance;
    }
}
