using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public bool EnemyHit = false;
    public float Health = 0f;
    public ShootingController shootingController;
    public void EnemyDamage(float damage)
    {
        Health -= damage;
        if (Health <= -0f)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
