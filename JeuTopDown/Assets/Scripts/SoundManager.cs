using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager InstanceSoundManger;

    [SerializeField] private AudioSource _effectSource;

    private void Awake()
    {
        InstanceSoundManger = this;
    }

    public void PlaySound(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }
}
