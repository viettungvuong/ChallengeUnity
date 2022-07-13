using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float range;
    public Camera cam;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            shootGun();
    }

    void shootGun()
    {
        RaycastHit shootHit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out shootHit, range))
        {
            if (shootHit.transform.CompareTag("enemy"))
                incrementScore();
        }
    }

    void incrementScore()
    {
        Game.score++;
    }
}
