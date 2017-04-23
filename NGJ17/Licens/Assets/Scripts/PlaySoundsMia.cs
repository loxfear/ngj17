using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsMia : MonoBehaviour {

    public AudioClip[] gravel;
    public AudioSource source;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (source.isPlaying) return;
        source.clip = gravel[Random.Range(0, gravel.Length)];
        source.Play();
    }
}
