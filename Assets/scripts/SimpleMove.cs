﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Iniciou");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Passou um frame");
        transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
    }
}
