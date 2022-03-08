using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [Range(1,50)]
    public float jumpVelocity;
  

    void Update()
    {
         if (Input.GetKey(KeyCode.Space))
         {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;

         }   
    }
}
