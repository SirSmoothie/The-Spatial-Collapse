using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{

    public bool Target = false;
    //public float range = 100f;
    //public GameObject Target;
    public float damage = 20f;
    public TargetController targetController;
    public FriendlyController friendlyController;
    public Game4Controller game4Controller;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the camera to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the raycast hit an enemy
                FriendlyController friendlyController = hit.collider.GetComponent<FriendlyController>();
                if (friendlyController != null)
                {
                    // Deal damage to the enemy
                    friendlyController.FriendlyDamage(damage);
                    game4Controller.FriendKilled(1);
                }

            }  
            
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the raycast hit an enemy
                TargetController targetController = hit.collider.GetComponent<TargetController>();
                if (targetController != null)
                {
                    // Deal damage to the enemy
                    targetController.EnemyDamage(damage);
                    game4Controller.EnemyKilled(1);
                }

            }
            


        }

    }
}
