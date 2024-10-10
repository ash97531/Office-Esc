using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSoundManager : MonoBehaviour
{
    [SerializeField]
    List<AudioSource> soundSources;
    // Start is called before the first frame update

    IEnumerator StopSourceAfterPlaying(AudioSource source)
    {
        var waitForClipRemainingTime = new WaitForSeconds(source.clip.length);
        yield return waitForClipRemainingTime;
        soundSources.Remove(source);
    }

    public void AddSource(AudioSource source)
    {
        if(soundSources.Count < 4)
        {
            soundSources.Add(source);
            source.Play();
            StartCoroutine(StopSourceAfterPlaying(source));
        }
    }
}
