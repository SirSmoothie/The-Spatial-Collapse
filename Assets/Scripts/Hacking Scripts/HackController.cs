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
    public bool newrotation = false;
    public bool rotatedproperly = false;

    //The win degrees need to be in a multitude of -60's (0, -60, -120, -180, -240, -300)




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
        if (WinDegree == Z && newrotation == true)
        {
            print("You aligned it babe!");
            newrotation = false;
            rotatedproperly = true;
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
            newrotation = true;
            Rotate = false;
            rotatedproperly = false;
        }
    }
}
