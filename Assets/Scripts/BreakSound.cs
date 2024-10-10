using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakSound : MonoBehaviour
{
    [SerializeField]
    AudioSource m_AudioSource;
    //[SerializeField]
    //AudioClip m_Clip;

    public void PlayBreakSound()
    {
        m_AudioSource.Play();
    }


}
