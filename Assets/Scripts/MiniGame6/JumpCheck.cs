using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InJumpCheck = true;

        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //eventBus.Current.RemoveLife();
            collider.gameObject.GetComponent<CharacterSkills>().InJumpCheck = false;

        }
    }
}
