using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnBullet;
    public float speed;
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
        Vector3 rotation = new Vector3(0, -90, -90);
        Quaternion rotationQ = Quaternion.Euler(rotation);
        GameObject newBullet = Instantiate(bullet, spawnBullet.position, rotationQ);
        Physics.IgnoreCollision(newBullet.GetComponent<Collider>(),
            spawnBullet.parent.GetComponent<Collider>()); //kh quan tam va cham giua 2 thang nay de tranh dan kh bay ra duoc
        newBullet.transform.position = spawnBullet.position;

        newBullet.GetComponent<Rigidbody>().AddForce(spawnBullet.forward * speed, ForceMode.Impulse);
    }


}
