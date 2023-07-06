using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackMovement : MonoBehaviour
{
    public Camera camera;
    public HackController hackController;
    public GameObject Cube;
    public bool HitSomething;
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
                HitSomething = true;
            }
        }

        hackController = Cube.GetComponent<HackController>();

        if(HitSomething == true)
        {
            RotatePiece();
            HitSomething = false;
        }
    }

    public void RotatePiece()
    {
        hackController.RotatePiece(true);
    }
}
