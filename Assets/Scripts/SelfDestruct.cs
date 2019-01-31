using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    private AudioSource audioSrc;
    public AudioClip explosionClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.clip = explosionClip;
        audioSrc.Play();
        Destroy(gameObject, 3.0f);
    }
}
