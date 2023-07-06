using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class CuttingPath : MonoBehaviour
{
    public bool pathstart = false;
    public bool Checkpoint1 = false;
    public bool Checkpoint2 = false;
    public bool Checkpoint3 = false;
    public bool Checkpoint4 = false;
    public bool Checkpoint0 = true;
    public bool FirstActivation = true;
    public float speed = 2;
    public float time = 0;
    public int pathcut = 0;
    public bool IsWorking = true;
    public void cutting(int cuttingpath)
    {
        pathcut = pathcut + cuttingpath;
    }
    void Update()
    {
        if(pathcut == 1)
        {
            pathstart = true;
        }
        if(pathcut >= 2 && IsWorking == true)
        {
            print("You fail");
            speed = 0;
            IsWorking = false;
            pathstart = false;
        }

        time = time + Time.deltaTime;
        if (pathstart == true)
        {
            if(Checkpoint0 == true)
            {
                if(FirstActivation == true)
                {
                    time = 0;
                    FirstActivation = false;
                }
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                if(time >= 4)
                {
                    Checkpoint1 = true;
                    time = 0;
                    Checkpoint0 = false;
                }
            }
            if(Checkpoint1 == true)
            {
                speed = 1;
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                if (time >= 4)
                {
                    Checkpoint2 = true;
                    time = 0;
                    Checkpoint1 = false;
                }
            }
            if(Checkpoint2 == true)
            {
                speed = 4;
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                if (time >= 2)
                {
                    Checkpoint3 = true;
                    time = 0;
                    Checkpoint2 = false;
                }
            }
            if(Checkpoint3 == true)
            {
                speed = 1;
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                if (time >= 4)
                {
                    Checkpoint4 = true;
                    time = 0;
                    Checkpoint3 = false;
                }
            }
            if(Checkpoint4 == true)
            {
                speed = 2;
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                if (time >= 4)
                {
                    print("you got to the end!");
                    Checkpoint4 = false;
                }
            }
        }
    }
}
