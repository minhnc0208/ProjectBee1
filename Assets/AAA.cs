﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAA : MonoBehaviour
{
    public static AAA Instance;

    public int sodong;
    public int socot;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        DontDestroyOnLoad(gameObject);
        
        
    }
}
