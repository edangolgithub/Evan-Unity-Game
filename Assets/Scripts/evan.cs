using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evan : MonoBehaviour
{
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
       //rb.useGravity=true;
       rb.AddForce(200,200,700);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() 
    {
        
    }
}
