
using System;
using Unity.VisualScripting;
using UnityEngine;

public class MouseTracking : MonoBehaviour
{
    public Camera camera;
    public bool cubeTouched = false;
    public bool TorchOn = false;
    public GameObject Cube;
    public CuttingPath cuttingPath;
    public bool FirstActivation = true;
    public GameObject Wall;
    //public Wall_health wall_health;

    void Update()
    {
        RaycastHit hit;
        

        if (Input.GetMouseButtonDown(0))
        {
            TorchOn = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            TorchOn = false;
            cutting();
        }

        if (TorchOn == true)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Cube = hit.transform.gameObject;
                cubeTouched = true;
                if(Cube == Wall)
                {
                    cutting();
                }
            }
        }
        if(cubeTouched == true)
        {
            if(FirstActivation == true)
            {
                cutting();
                FirstActivation = false;
            }
        }

       // wall_health = Cube.GetComponent<Wall_health>();
    }

    public void cutting()
    {
        cuttingPath.cutting(1);
    }
    //public void AddDmg()
    //{
    //    wall_health.AddDmg(1);
    //}
}
