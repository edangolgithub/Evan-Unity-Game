using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csss : MonoBehaviour
{
    public Light l;


    void Start()
    {
        
    }

    void Update () {
        if (Input.GetKey ("space")) {
            l.enabled = true;
        } else {
            l.enabled = false;
        }
    }
}
