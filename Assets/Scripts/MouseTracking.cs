using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseTracking : MonoBehaviour
{
    public Camera camera;

    public bool cubetouched = false;
    public bool TorchOn = false;

    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
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
        }

        if (TorchOn == true)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;

                //hit = GameObject.SetActive(false);

                print("you fucking suck you loser get out of this area and die");

                Cube = hit.transform.gameObject;
                cubetouched = true;
            }
        }


         

























        if (cubetouched == true)
        {
            Cube.SetActive(false);
            cubetouched = false;
        }
    }
}
