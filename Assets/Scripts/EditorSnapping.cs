﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class EditorSnapping : MonoBehaviour {

    const int gridSize = 10;
 //   [SerializeField][Range (1f, 20f)] float gridSize = 10f;

    TextMesh textMesh;

    void Update () {  

        Vector3 snapPos;

        snapPos.x = Mathf.RoundToInt (transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt (transform.position.z / gridSize) * gridSize;
        transform.position = new Vector3 (snapPos.x, 0f, snapPos.z);

        textMesh = GetComponentInChildren<TextMesh>();
        string labelText = (snapPos.x / gridSize + "," + snapPos.z / gridSize);
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}