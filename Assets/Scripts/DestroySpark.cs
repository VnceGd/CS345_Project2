using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpark : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
        Destroy(gameObject, 1);
    }
}
