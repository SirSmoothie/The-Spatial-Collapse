using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashWarningCheck : MonoBehaviour
{
    public GameObject Lightsoff;
    public GameObject Lighton;
    private void Start()
    {
        Lighton.SetActive(false);
        Lightsoff.SetActive(true);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            LightsOn();
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            LightsOff();
        }
    }

    public void LightsOn()
    {
        Lighton.gameObject.SetActive(true);
        Lightsoff.gameObject.SetActive(false);
    }

    public void LightsOff()
    {
        Lightsoff.gameObject.SetActive(true);
        Lighton.gameObject.SetActive(false);
    }
}
