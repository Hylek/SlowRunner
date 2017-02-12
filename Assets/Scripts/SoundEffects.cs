using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public static SoundEffects Instance;

    public AudioClip dingSound;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("Multiple instances of SoundEffects!");
        }
        Instance = this;
    }

    public void MakeDingSound()
    {
        MakeSound(dingSound);
    }

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
