using System.Collections;
using System.Collections.Generic;
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
        //if (Input.GetKeyDown("e"))
        //{
            //transform.Rotate(X, Y, Z + 60f);
            //print(Z);
        //}
        //if (Input.GetKeyDown("e") && WinDegree == GameObject.eulerAngles.z)
        //{
            //print("Victory!");
        //}
        if (WinDegree == Z)
        {
            print("You aligned it babe!");
        }
        if(Z == -360f)
        {
            Z = 0f;
        }
    }

    public void RotatePiece(bool Rotate)
    {
        if(Rotate = true)
        {
            Z = Z + -60f;
            transform.Rotate(X, Y, -60f);
            print(Z);
            Rotate = false;
        }
    }
}
