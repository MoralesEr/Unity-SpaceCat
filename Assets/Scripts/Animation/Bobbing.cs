using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Bobbing : MonoBehaviour
{
    float originalY;

    private float floatStrength = 0.1f;

    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Math.Sin(Time.time) * floatStrength),
            transform.position.z);
    }
}