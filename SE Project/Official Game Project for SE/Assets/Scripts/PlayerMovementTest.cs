﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTest : MonoBehaviour
{
    public float moveSpeed;

    
    void Start() {
        moveSpeed = 60f;
    }

    
    void Update() {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime , 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
