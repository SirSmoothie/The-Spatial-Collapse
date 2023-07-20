using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCheck : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InHideCheck = true;

        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InHideCheck = false;

        }
    }
}
