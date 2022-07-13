using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject gun, bullet;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void shootGun()
    {
        GameObject shootBullet = Instantiate(bullet, bullet.transform.position, bullet.transform.rotation);
        shootBullet.transform.parent = gun.transform; //dat dan vao sung
        shootBullet.GetComponent<Rigidbody>().velocity = speed * transform.forward;
    }
}
