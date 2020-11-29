using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNavigation : MonoBehaviour {
    public Button button;
    public Animator pnlAudio;
    public Animator pnlPaused;


    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            CloseAudioMenu();
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

    //exit game
    public void QuiteGame() {
        SceneManager.LoadScene("StartScreen");
    }

    //close pause menu
    public void ClosePauseMenu() {
        pnlPaused.SetBool("open", false);
    }

    //open pause menu
    public void OpenPauseMenu() {
        pnlAudio.SetBool("open", false); ;
        pnlPaused.SetBool("open", true);
    }

    //open audio menu
    public void OpenAudioMenu() {
        pnlPaused.SetBool("open", false);
        pnlAudio.SetBool("open", true);
    }

    //close audio menu
    public void CloseAudioMenu() {
        pnlAudio.SetBool("open", false);
        pnlPaused.SetBool("open", true);
    }
}
