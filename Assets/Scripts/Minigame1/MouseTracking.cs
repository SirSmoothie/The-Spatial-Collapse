
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
    public GameObject TorchingCube;
    public GameObject Particles;
    public AudioSource TorchSound;
    public AudioClip TorchSoundClip;
    public bool PlayingSound;

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
            Particles.gameObject.SetActive(true);
            StartSound();

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                Cube = hit.transform.gameObject;
                if (Cube == TorchingCube)
                {
                    cubeTouched = true;
                }
                if (Cube == Wall && FirstActivation == false)
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

        if(TorchOn == false) 
        {
            Particles.gameObject.SetActive(false);
            StopSound();
        }
       // wall_health = Cube.GetComponent<Wall_health>();
    }

    public void cutting()
    {
        if(cubeTouched == true)
        {
            cuttingPath.cutting(1);
        }
    }
    public void StartSound()
    {        
        if(PlayingSound == true)
        {
            PlayingSound = false;
            TorchSound.clip = TorchSoundClip;
            TorchSound.Play();
        }
    }
    public void StopSound() 
    {
        PlayingSound = true;
        TorchSound.Stop();
    } 



    //public void AddDmg()
    //{
    //    wall_health.AddDmg(1);
    //}
}
