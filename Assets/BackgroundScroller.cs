using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float x = 1;
    public float speed = 1;
    public float AccelerationFactor = 1f;

    public bool start = true;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (start == true)
        {
            rigidbody.velocity = new Vector3(x * speed, rigidbody.velocity.y, rigidbody.velocity.z);
        }
        if (start == false)
        {
            rigidbody.velocity = new Vector3(0, 0, 0);
        }
        speed = speed + AccelerationFactor;
    }
}
