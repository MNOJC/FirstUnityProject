using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixerGroup soundEffect;
    public static AudioManager instance;

    private void Awake()
    {
        instance = this;
    }

    public AudioSource PlaySoundAt(AudioClip clip, Vector3 pos)
    {
        GameObject tempGO = new GameObject("TempAudio");
        tempGO.transform.position = pos;
        AudioSource audioSource = tempGO.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.outputAudioMixerGroup = soundEffect;
        audioSource.Play();
        Destroy(tempGO, clip.length);
        return audioSource;
    }
}
