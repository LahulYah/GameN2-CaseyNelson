using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
    Transform transPosition;

    void Update()   
    {
        transform.position = transPosition.position;
    }
}
