using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFade : MonoBehaviour
{
    public float fadeSpeed = 7.0f;

    private Light lt;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();   
    }

    // Update is called once per frame
    void Update()
    {
        lt.range -= Time.deltaTime * fadeSpeed;
        if(lt.range <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
