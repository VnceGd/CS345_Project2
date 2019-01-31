using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletSpark;

    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(bulletSpark, transform);
        Destroy(gameObject, 0.05f);

        GameObject collidedObject = collision.gameObject;
        if(collidedObject.tag == "Target")
        {
            collidedObject.transform.position += Vector3.forward;
        }
    }
}
