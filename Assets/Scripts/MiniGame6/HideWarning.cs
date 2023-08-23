using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HideWarning : MonoBehaviour
{
    public GameObject Warning;
    private void Start()
    {
        Warning.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            WarningOn();
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            WarningOff();
        }
    }

    public void WarningOn()
    {
        Warning.gameObject.SetActive(false);
    }

    public void WarningOff()
    {
        Warning.gameObject.SetActive(true);
    }
}
