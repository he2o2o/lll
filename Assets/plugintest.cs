﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class plugintest : MonoBehaviour
{
    const string DLL_NAME = "Project2";
    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(SimpleFunction());
        }
    }
}