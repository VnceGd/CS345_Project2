using UnityEngine;

public class ExplosiveBarrel : MonoBehaviour
{
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Destroy self, spawn explosion particles
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            GameObject explosionClone = Instantiate(explosion, transform);
            explosionClone.transform.parent = null;
            Destroy(gameObject);
        }
    }
}
