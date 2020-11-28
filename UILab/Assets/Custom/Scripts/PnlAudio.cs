
using UnityEngine;

public class PnlAudio : MonoBehaviour {
    public static PnlAudio Instance;

    public Animator anim;

    private void Update() {
        anim = GetComponent<Animator>();
        Instance = this;
    }
}
