using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireScript : MonoBehaviour
{
    private LineRenderer Line;
    [SerializeField] private string destinationTag;

    private bool hasLost = false;
    private bool hasWon = false;
    private Vector3 offset;
    public WinnerG5 winnerG5;


    private void Start()
    {
        Line = GetComponent<LineRenderer>();
    }

    private void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        Line.SetPosition(0, MouseWorldPosition() + offset);
        Line.SetPosition(1, transform.position);
    }




    private void OnMouseUp()
    {
        if (hasLost || hasWon) return;

        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;

        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if (hitInfo.transform.CompareTag(destinationTag))
            {
                Line.SetPosition(0, hitInfo.transform.position);
                transform.gameObject.GetComponent<Collider>().enabled = false;
                //Debug.Log("You win");
                hasWon = true;
                winnerG5.ConnectedAWire(1);
            }
            else
            {
                Line.SetPosition(0, hitInfo.point);
                //Debug.Log("You lose");
                hasLost = true;
            }
        }
    }





    private Vector3 MouseWorldPosition()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}