﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteOne : MonoBehaviour
{
    public GameObject sub;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
        sub.GetComponent<Subtitles>().FirstNote();
    }

    public void PutAway()
    {
        GameObject.Find("AS1").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteOne = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
