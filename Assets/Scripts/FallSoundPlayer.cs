using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FallSoundPlayer : MonoBehaviour
{
    [SerializeField]
    FallSoundManager soundManager;

    AudioSource fallSoundSource;

    private void Start()
    {
        fallSoundSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > 1)
        {
            soundManager.AddSource(fallSoundSource);
        }
    }

}
