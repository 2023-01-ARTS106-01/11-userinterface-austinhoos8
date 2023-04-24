using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    public Animator settingsDialog;

    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }

    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        settingsDialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        startButton.SetBool("isHidden", false);
        settingsButton.SetBool("isHidden", false);
        settingsDialog.SetBool("isHidden", true);
    }
    
}
