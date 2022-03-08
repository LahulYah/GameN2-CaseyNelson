using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulsion : MonoBehaviour
{
    [Range(1, 50)]
    public float jumpVelocity;


    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpVelocity;

        }
    }
}
