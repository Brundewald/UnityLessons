using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _player;
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
            if (!_isPaused)
            {
                PauseGame();
                _startButton.onClick.AddListener(ResumeGame);
                _quitButton.onClick.AddListener(Quit);
            }

            else
            {
                ResumeGame();
                _startButton.onClick.RemoveAllListeners();
                _quitButton.onClick.RemoveAllListeners();
            }          
        }
    }

    private void PauseGame()
    {
        _pauseMenu.SetActive(true);
        _isPaused = true;
        Time.timeScale = 0f;
        Cursor.visible = true;
        _player.GetComponent<MouseLookControll>().enabled = false; 
    }

    private void ResumeGame()
    {
        _player.GetComponent<MouseLookControll>().enabled = true;
        _pauseMenu.SetActive(false);
        _isPaused = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
        _startButton.onClick.RemoveAllListeners();
        _quitButton.onClick.RemoveAllListeners();
    }

    private void Quit() 
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    
}
