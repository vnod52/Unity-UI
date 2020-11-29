using UnityEngine;

public class VolumeChange : MonoBehaviour {
    private AudioSource audioSrc;
    private float musicVolume = 1f;

    //Get the audio source component
    private void Start() {
        audioSrc = GetComponent<AudioSource>();
    }

    //Set audio src volume
    private void Update() {
        audioSrc.volume = musicVolume;
    }

    //Set new music volume
    public void SetVolume(float vol) {
        musicVolume = vol;
    }
}
