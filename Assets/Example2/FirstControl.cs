using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstControl : MonoBehaviour
{
    public CubePrefab cubePrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateCubePrefab();
        }
    }

    private void CreateCubePrefab()
    {
        Vector3 mousePos = Input.mousePosition;

        Instantiate(cubePrefab, mousePos, transform.rotation);
    }
}
