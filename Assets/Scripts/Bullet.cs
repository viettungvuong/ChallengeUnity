using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);
        if (other.gameObject.CompareTag("enemy"))
        {
            Game.incrementScore();
            Destroy(other);
        }
    }
}
