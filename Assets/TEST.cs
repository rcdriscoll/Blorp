﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsController.SetMasterVolume(.5f);
        Debug.Log("Returned value of " + PlayerPrefsController.GetMasterVolume());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
