using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedWireScript : MonoBehaviour
{
    private LineRenderer Line;
    [SerializeField] private string destinationTag;

    private Vector3 offset;

    private void Start()
    {
        Line = GetComponent<LineRenderer>();
    }

    private void OnMouseDown()
    {
        offset = transform.postion - MouseWorldPostition();
    }

    private void OnMouseDrag()
    {
        line.SetPosition(0, MouseWorldPosition() + offset);
        line.SetPosition(1, TransformPosition);
    }

    private void OnMouseUp()
    {
        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;

<<<<<<< Updated upstream
        if(Physics.Raycast(rayorigin,RayDir, out hitInfo)) 
        { 
            if(hitInfo.transform.tag == destinationTag) 
            {
            Line.SetPosition(0,hitInfo.transform.position);
                transform.gameObject.GetComponent<Collider>.enabled = false;
=======
        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if (hitInfo.transform.CompareTag(destinationTag))
            {
                Line.SetPosition(0, hitInfo.transform.position);
                transform.gameObject.GetComponent<Collider>().enabled = false;
>>>>>>> Stashed changes
            }
            else
            {
                Line.SetPosition(0, hitInfo.point);
            }
        }
    }

    private Vector3 MouseWorldPosition()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint.(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}