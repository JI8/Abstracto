using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplay : MonoBehaviour {

    private AudioSource soundSource;
    public AudioClip[] soundClips;

	void Start ()
    {
        soundSource = GetComponent<AudioSource>();
      
	}

    void OnTriggerEnter(Collider other)
    {
        AudioClip randomClip = soundClips[Random.Range(0, soundClips.Length)];

        if (soundSource != null)
        {
            soundSource.clip = randomClip;
            soundSource.Play();
        }
    }
}

