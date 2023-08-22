using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float offset = 3f;
    public Vector3 pos;
    void Update()
    {
        pos = Input.mousePosition;
        pos.z = offset;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }

    
}
