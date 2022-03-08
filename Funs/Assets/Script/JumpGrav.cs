using System.Collections;
using UnityEngine;

public class JumpGrav : MonoBehaviour
{
    public float fallMultiply = 2.5f;
    public float lowJumpMultiply = 2f;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiply - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiply - 1) * Time.deltaTime;
        }
    }
}
