﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float verticle = Input.GetAxis("Vertical");
        this.transform.Translate(-horizontal,0 , -verticle);

    }
}
