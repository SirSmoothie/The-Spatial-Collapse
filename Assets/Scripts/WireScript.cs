using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireScript : MonoBehaviour
{
    private LineRenderer Line;
    [SerializeField] private string destinationTag;

    Vector3 offset;

    private void start()
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
        Vector3 rayOrigin = Camera.main.transform.position;
        Vector3 RayDir = MouseWorldPosition()-Camera.main.transform.forward;
        RaycastHit hitInfo;

        if(Physics.Raycast(rayOrigin,RayDir, out hitInfo)) 
        { 
            if(hitInfo.transform.tag == destinationTag) 
            {
                Line.SetPosition(0,hitInfo.transform.position);
                transform.gameObject.GetComponent<Collider>().enabled = false;
            }
            else
            {
                Line.SetPosition(0, hitInfo.transform.position);
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
