using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    private Vector3 spawnPosition;

    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
