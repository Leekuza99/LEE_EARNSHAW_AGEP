using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSounds : MonoBehaviour
{
    public static AudioClip gunSound;
    static AudioSource audioSrc;

    void Start()
    {
        gunSound = Resources.Load<AudioClip>("gunSound");
    }
}