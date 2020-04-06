﻿using UnityEngine;
using System.Collections;

public class PhoneRings : MonoBehaviour
{
    Material mat;
    void Start()
    {
        
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());

       
        
    }

    IEnumerator ExampleCoroutine()
    {


        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        mat = GetComponent<Renderer>().materials[1];
        mat.EnableKeyword("_EMISSION");
        GetComponent<AudioSource>().Play();

    }
}