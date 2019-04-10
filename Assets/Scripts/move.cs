using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class move : MonoBehaviour
{
    public float speed=1f;
    public Rigidbody rb;

     private void Start() {
        rb.useGravity=false;
    }
     void Update()
    {
        var h=Input.GetAxis("Horizontal");
        var v= Input.GetAxis("Vertical");

        Vector3 movement= new Vector3(h,v);
        transform.position+=movement* Time.deltaTime *speed;

    }

private void OnCollisionEnter(Collision other) {
    SceneManager.LoadScene(0);
}

}
