using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotate : MonoBehaviour
{
    public Vector3 TransformRotation;
    void FixedUpdate()
    {
        transform.Rotate(TransformRotation);
    }
}
