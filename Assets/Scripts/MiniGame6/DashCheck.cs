using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCheck : MonoBehaviour
{
    public GameObject Laser;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            collider.gameObject.GetComponent<CharacterSkills>().InDashCheck = true;
            Laser.SetActive(true);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            collider.gameObject.GetComponent<CharacterSkills>().InDashCheck = false;
            Laser.SetActive(false);
        }
    }
}
