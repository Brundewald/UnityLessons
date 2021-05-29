using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _startButton;   
    [SerializeField] private Button _quitButton;

    private void Start()
    {
        _startButton.onClick.AddListener(PlayButton);
        _quitButton.onClick.AddListener(QuitButton);
    }

    private void OnDestroy()
    {
        _startButton.onClick.RemoveAllListeners();
        _quitButton.onClick.RemoveAllListeners();
    }
    private void PlayButton() 
    {
        SceneManager.LoadScene(1);
    }
    
    private void QuitButton() 
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
