﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float outOfBoundsNorth = 30.0f;
    private float outofBoundsSouth = -10.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= outOfBoundsNorth)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= outofBoundsSouth)
        {
            Destroy(gameObject);
        }
    }
}
