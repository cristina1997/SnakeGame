﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuControl : MonoBehaviour {
    public Text highScore;

    // Use this for initialization
    void Start()
    {
        HighScore();
        // highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Menu() {
        SceneManager.LoadScene(0);
    } // Menu

    void HighScore()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();

    } // HighScore

    public void Quit()
    {
        Application.Quit();
    } // Quit

    public void DeleteScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    } // DeleteScore

} // PauseMenuControl
