using UnityEngine;

public class Movement : MonoBehaviour
{
    
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegavtive;
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
        {
            GetComponent<Rigidbody>().velocity += v3Force;

        }
        


        if (Input.GetKey(keyNegavtive))
        {
            GetComponent<Rigidbody>().velocity -= v3Force;
          
        }
        


    }
}
