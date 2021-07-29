using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UITitle : GameBehaviour
{
    public void LoadScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
   

    public void ToTitleScene()
    {
        SceneManager.LoadScene("Title");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
        _GM.ChangeGameState(Gamestate.InGame);
    }

    

    public void QuitGame()
    {
        Application.Quit();
    }
}
