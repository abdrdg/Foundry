using UnityEngine;

public class ButtonClickAudio : MonoBehaviour
{
    public AudioClip clickSFX;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (clickSFX != null)
        {
            audioSource.PlayOneShot(clickSFX);
        }
    }
}