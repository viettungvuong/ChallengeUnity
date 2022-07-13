using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    IEnumerator destroyBullet(int secs)
    {
        yield return new WaitForSeconds(secs);
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);
        if (collision.gameObject.CompareTag("enemy"))
        {
            Game.incrementScore();
            Destroy(collision.gameObject);
        }
        StartCoroutine(destroyBullet(10)); //xoa bullet sau khi dung vat 3s
    }
}
