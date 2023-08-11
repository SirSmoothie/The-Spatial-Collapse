using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackMovement : MonoBehaviour
{
    public Camera camera;
    public HackController hackController;
    public GameObject Cube;
    public Confirmationbutton confirmationbutton;
    public bool testvalue;

    public int AlignedPieces = 0;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Cube = hit.transform.gameObject;
                testvalue = true;
            }
        }

        hackController = Cube.GetComponent<HackController>();

        if (testvalue == true)
        {
            testvalue = false;
            HitSomething();
        }

        if (AlignedPieces >= 7)
        {
            confirmationbutton.Aligned(true);
        }
    }

    public void AlignedAPiece(int Piece)
    {
        AlignedPieces += Piece;
    }

    public void HitSomething()
    {
        hackController.Clicked(true);
    }
}
