﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Wind");
    }

    
}
