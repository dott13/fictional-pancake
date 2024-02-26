using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public string gameScene;

    public Button loadButton;

    public void Start()
    {
        loadButton.interactable = SaveManager.IsGameSaved();
    }
    public void NewGame()
    {
        SaveManager.ClearSavedGame();
        Load();
    }
    public void Load()
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
