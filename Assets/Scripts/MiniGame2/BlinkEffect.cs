using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkEffect : MonoBehaviour

{
    public Color StartColour = Color.green;
    public Color EndColour = Color.black;

    [Range(0, 10)]
    public float speed = 1;

    Renderer ren;

    void Awake()
    {
        ren = GetComponent<Renderer>();
    }

    void Update()
    {
        ren.material.color = Color.Lerp(StartColour, EndColour, Mathf.PingPong(Time.time * speed, 1));
    }
}

