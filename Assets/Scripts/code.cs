using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class code : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=1;
    void Start()
    {
        rb.useGravity=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        var h=Input.GetAxis("Horizontal");
        var v= Input.GetAxis("Vertical");

        Vector3 movement= new Vector3(h,v);
        transform.position+=movement* Time.deltaTime *speed;

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        SceneManager.LoadScene(0);
  
    }
}
