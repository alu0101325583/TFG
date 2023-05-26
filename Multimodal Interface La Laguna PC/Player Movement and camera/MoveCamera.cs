﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition;
    
    void Update()
    {
        this.transform.position = cameraPosition.position;
    }
}
