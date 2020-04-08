﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    #region Instance
    public static SoundManager instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
    #endregion

    [SerializeField] private AudioSource wheelSpin;
    [SerializeField] private float minecartSpeed = 1;
    [SerializeField] private AudioSource[] headHits;
    [SerializeField] private AudioSource groundHit;

    public static void SetWheelSpinSpeed(float speed)
    {
        speed *= instance.minecartSpeed;
        instance.wheelSpin.volume = Mathf.Max(0, speed - 0.15f);
        if (instance.wheelSpin.volume > 0)
        {
            if (!instance.wheelSpin.isPlaying)
                instance.wheelSpin.Play();
            instance.wheelSpin.pitch = speed;
            instance.wheelSpin.outputAudioMixerGroup.audioMixer.SetFloat("Pitch", 1f / speed);
        }
        else
            instance.wheelSpin.Stop();
    }

    public static void PlayHeadHit()
    {
        instance.headHits[Rand.Int(instance.headHits.Length)].Play();
    }

    public static void PlayGroundHit()
    {
        instance.groundHit.Play();
    }
}
