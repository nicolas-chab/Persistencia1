﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigov1 : MonoBehaviour
{
    public bool isAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        
        isAlive=false;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
}
