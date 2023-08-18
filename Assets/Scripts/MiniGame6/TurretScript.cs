using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        player = GameObject.Find("Player");
        Player = player.transform;
    }
    public Transform Player;

    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDirection = Player.position - transform.position;

        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0f);

        Debug.DrawRay(transform.position, newDirection, Color.red);

        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
