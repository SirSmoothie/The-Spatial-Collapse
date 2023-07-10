using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{

    public bool Target = false;
    //public GameObject Target;
    public float damage = 20f;
    public TargetController targetController;
    public FriendlyController friendlyController;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
            if (Target = EnemyHit)
                {
                    targetController.EnemyDamage(damage);
                }
                if (Target = FriendlyHit)
                {
                    friendlyController.FriendlyDamage(damage);
                }
            }
        }   
    }
}
