using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideCheck : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InSlideCheck = true;

        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InSlideCheck = false;

        }
    }
}
