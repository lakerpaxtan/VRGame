﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collision : MonoBehaviour
{
    public OVRInput.Controller controller;

    private float handTriggerState = 0;
  


    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        handTriggerState = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);
        if (handTriggerState < 0.9f)
        {
            GameObject other = collision.gameObject;
            this.transform.parent = other.transform;
        }
    }

}