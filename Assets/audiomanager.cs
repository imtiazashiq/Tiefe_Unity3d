using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static AudioPlayerManager instance = null;
    private AudioSource audio;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }

        if (instance == this) return;
        Destroy(gameObject);
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
