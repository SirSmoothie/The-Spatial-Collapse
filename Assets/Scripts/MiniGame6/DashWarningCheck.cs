using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashWarningCheck : MonoBehaviour
{
    public GameObject Lights;
    private void Start()
    {
        Lights.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            LightsOn();
        }
    }

    public void LightsOn()
    {
        Lights.SetActive(true);
    }
}
