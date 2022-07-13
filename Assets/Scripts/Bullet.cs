using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);
        if (collision.gameObject.CompareTag("enemy"))
        {
            Game.incrementScore();
            Destroy(collision.gameObject);
        }
    }
}
