using UnityEngine;
using UnityEngine.UI;

public class Toogle : MonoBehaviour {
    private Toggle toogle;

    // Update is called once per frame
    void Update() {
        toogle = GetComponent<Toggle>();
    }

    //Mute or unmute the audio
    public void Muted() {
        if (toogle.isOn) {
            AudioListener.volume = 0;
        } else {
            AudioListener.volume = 0.5f;

        }
    }
}
