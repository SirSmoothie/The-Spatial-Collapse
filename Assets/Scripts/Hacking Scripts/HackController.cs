using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HackController : MonoBehaviour
{
    public Transform GameObject;
    public float X = 0f;
    public float Y = 0f;
    public float Z = 0f;
    public float WinDegree = 0f;
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            transform.Rotate(X, Y, Z + 60f);
            print(Z);
        }
        if (Input.GetKeyDown("e") && WinDegree == GameObject.eulerAngles.z)
        {
            print("Victory!");
        }
    }
}
