﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private const string _sceneGame = "Game";
    public void LaunchGame()
    {
        SceneManager.LoadScene(_sceneGame);
    }

    public void GoOut()
    {
        Application.Quit();
    }
}
