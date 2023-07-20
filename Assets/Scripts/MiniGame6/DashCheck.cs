using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCheck : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InDashCheck = true;

        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InDashCheck = false;

        }
    }
}
