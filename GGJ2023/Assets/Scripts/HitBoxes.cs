using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitBoxes : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("hit");
        }

    }
}