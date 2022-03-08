using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldForce : MonoBehaviour
{

    [SerializeField]
    Vector3 worldForce;

    void Update()
    {
        GetComponent<Rigidbody>().velocity += worldForce;
    }
}
