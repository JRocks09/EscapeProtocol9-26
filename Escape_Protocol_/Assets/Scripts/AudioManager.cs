using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip --------")]
    public AudioClip background;
    public AudioClip jump;
    public AudioClip damageTaken;
    public AudioClip attack;
    public AudioClip itemCollect;
    public AudioClip door;
    public AudioClip checkpoint;
    public AudioClip boxPush;
    public AudioClip buttonPush;
    public AudioClip dead;
    public AudioClip keyPick;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip, float volume = 1.0f)
    {
        SFXSource.PlayOneShot(clip, volume);
    }
}
