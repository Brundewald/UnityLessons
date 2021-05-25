using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject _pauseMenu;
    [SerializeField] private Button _startButton;    
    [SerializeField] private Button _quitButton;

    private bool _isPaused;

    private void Awake()
    {
        _pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {            
            if (_isPaused)
            {
                ResumeGame();
            }

            else
            {
                PauseGame();
            }          
        }
        if (_isPaused)
        {
            
        }
        else 
        {
            _startButton.onClick.AddListener(ResumeGame);
            _quitButton.onClick.AddListener(Quit);
        }
        
    }

    private void PauseGame()
    {
        _pauseMenu.SetActive(true);
        _isPaused = true;
        Time.timeScale = 0f;
    }

    private void ResumeGame()
    {
        _pauseMenu.SetActive(false);
        _isPaused = false;
        Time.timeScale = 1f;
    }

    private void Quit() 
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    
}
