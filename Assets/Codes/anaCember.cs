﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anaCember : MonoBehaviour
{
    public GameObject kucukCember;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukCemberOlustur();
        }
    }
    void kucukCemberOlustur()
    {
        Instantiate(kucukCember,transform.position,transform.rotation);
    }
}
