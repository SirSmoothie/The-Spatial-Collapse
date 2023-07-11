using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackController : MonoBehaviour
{
    public Transform GameObject;
    public HackMovement hackMovement;
    public float X = 0f;
    public float Y = 0f;
    public float Z = 0f;
    public float WinDegree = 0f;
    public bool newrotation = false;
    public bool rotatedproperly = false;
    public float Dealignedpostion = 0;
    public bool Dealigned = false;

    //The win degrees need to be in a multitude of -60's (0, -60, -120, -180, -240, -300)

    void Start()
    {
        Dealignedpostion = WinDegree - 60f;
    }

    public void Clicked(bool clicked)
    {
        if (clicked == true)
        {
            RotatePiece(true);
            clicked = false;
        }
    }

    void Update()
    {
        if(Dealignedpostion == -360f)
        {
            Dealignedpostion = 0f;
        }
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
            print("Correct");
            newrotation = false;
            rotatedproperly = true;
            hackMovement.AlignedAPiece(1);
            Dealigned = true;
        }
        if(Z == -360f)
        {
            Z = 0f;
            rotatedproperly = false;
        }

        if (Dealignedpostion == Z && Dealigned == true)
        {
            hackMovement.AlignedAPiece(-1);
            Dealigned = false;
        }
    }

    public void RotatePiece(bool Rotate)
    {
        if(Rotate == true)
        {
            Z = Z + -60f;
            transform.Rotate(X, Y, -60f);
            newrotation = true;
            Rotate = false;
            rotatedproperly = false;
        }
        
    }
}
