using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class CellData
{
    [SerializeField]
    private Color color;
    [SerializeField]
    private Vector2 position;
    [SerializeField]
    private GameObject gridObject;


    public CellData(Color _color, Vector2 _position, GameObject _gridObject)
    {
        color = _color;
        position = _position;
        gridObject = _gridObject;
    }

    public Vector2 Position { get => position; set => position = value; }
    public Color Color { get => color; set => color = value; }
    public GameObject GridObject { get => gridObject; set => gridObject = value; }


}
