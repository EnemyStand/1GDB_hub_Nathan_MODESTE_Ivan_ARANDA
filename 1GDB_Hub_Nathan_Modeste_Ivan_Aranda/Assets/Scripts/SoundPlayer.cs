using UnityEngine;
using Unity;

class SoundPlayer : MonoBehaviour
{

    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;

    public void Start()
    {

    }

    public void OnTriggerEnter(Collider collider)
    {
        if (clip)
        {
            source.clip = clip;
            source.Play();
        }

    }

    public void OnTriggerExit(Collider collider)
    {
        source.Stop();
        source.clip = null;
    }
}
