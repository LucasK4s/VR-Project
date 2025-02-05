﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Manager.Instance.sixthTrigger == true && !GetComponent<MeshRenderer>().isVisible)
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Manager.Instance.seventhTrigger == true && !GetComponent<MeshRenderer>().isVisible)
        {
            gameObject.SetActive(false);
        }
    }

    public void PickUp()
    {
        GetComponent<AudioSource>().Play();
    }

    public void PutAway()
    {
        GameObject.Find("AS10").GetComponent<AudioSource>().Play();
        Manager.Instance.NoteTen = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
