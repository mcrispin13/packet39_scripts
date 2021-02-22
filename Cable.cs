﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    public Transform cable;
    // Start is called before the first frame update

    public Transform magnet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, cable.position);
        lineRenderer.SetPosition(1, magnet.position);
    }
}
