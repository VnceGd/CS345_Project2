using UnityEngine;

public class GunFire : MonoBehaviour
{
    public int speed = 1000;
    public GameObject bullet;
    public GameObject barrelSmoke;
    public GameObject muzzleFlash;

    private AudioSource audioSrc;
    public AudioClip gunShot;

    public void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.clip = gunShot;
        audioSrc.time = 0.25f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioSrc.Play();
            Instantiate(muzzleFlash, transform.position + transform.forward, transform.rotation);
            GameObject smoke_clone = Instantiate(barrelSmoke, transform);
            Destroy(smoke_clone, 1.0f);
            GameObject bullet_clone = Instantiate(bullet, transform);
            if (bullet_clone != null)
                bullet_clone.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
    }
}
