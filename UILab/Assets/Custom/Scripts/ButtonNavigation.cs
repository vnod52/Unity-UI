using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNavigation : MonoBehaviour {
    public Button button;
    public Animator pnlAudio;
    public Animator pnlPaused;


    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("Esc key pressed");
            OpenPauseMenu();
        }
    }

    //open game scene
    public void StartGame() {
        SceneManager.LoadScene("Game");
    }

    //close application
    public void CloseApplication() {
        Application.Quit();
    }

    //close pause menu
    public void ClosePauseMenu() {
        pnlPaused.SetBool("open", false);
    }

    //Open pause menu
    public void OpenPauseMenu() {
        pnlPaused.SetBool("open", true);
    }

    //open audio menu
    public void OpenAudioMenu() {
        ClosePauseMenu();
        pnlAudio.SetBool("open", true);
    }

    //close audio menu
    public void CloseAudioMenu() {
        pnlAudio.SetBool("open", false);
    }


}
