using UnityEngine;

public class PnlPause : MonoBehaviour {
    public static PnlPause Instance;

    public Animator anim;

    private void Update() {
        anim = GetComponent<Animator>();
        Instance = this;
    }

}
