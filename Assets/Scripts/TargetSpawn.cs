using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public GameObject targetArray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTargets()
    {
        foreach(Transform target in targetArray.GetComponentInChildren<Transform>())
        {
            target.position = new Vector3(target.position.x, target.position.y, targetArray.transform.position.z);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            SpawnTargets();
        }
    }
}
