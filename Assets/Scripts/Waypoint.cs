﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {
    Vector2Int gridPos;

    const int gridSize = 10;

    void Start () { }

    public int GetGridSize () { return gridSize; }

    public Vector2Int GetGridPos () {
        return new Vector2Int (Mathf.RoundToInt(transform.position.x / gridSize) * gridSize, Mathf.RoundToInt(transform.position.z / gridSize) * gridSize);
    }

    void Update () { }
}