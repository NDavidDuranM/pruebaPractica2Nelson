using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    private void Start()
    {
        AudioManager.Instance.PlayBackgroundMusic(AudioManager.BackgroundMusic.BackgroundMusic);
    }

    void Update()
    {

    }
}
