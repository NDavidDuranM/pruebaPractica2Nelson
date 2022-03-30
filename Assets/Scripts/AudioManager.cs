using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum SoundEffect
    {
        Fire1,
        Fire2,
        Fire3
    }

    public enum BackgroundMusic
    {
        BackgroundMusic
    }

    public AudioSource fireEffect;
    public AudioSource music;

    public static AudioManager Instance;
    private void Awake()
    {
        Instance = this;
    }

    public void PlaySoundEffect(SoundEffect type)
    {
        switch(type)
        {
            case SoundEffect.Fire1:
                fireEffect.Play();
                break;
            case SoundEffect.Fire2:
                fireEffect.Play();
                break;
            case SoundEffect.Fire3:
                fireEffect.Play();
                break;
        }
    }

    public void PlayBackgroundMusic(BackgroundMusic type)
    {
        switch (type)
        {
            case BackgroundMusic.BackgroundMusic:
                music.Play();
                break;
        }
    }
}
