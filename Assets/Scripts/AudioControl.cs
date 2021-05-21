using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioControl : MonoBehaviour
{
    private static AudioControl _instance;

    private void Awake()
    {
        if (_instance == null) 
        {
            _instance = this;
        }
           
        else 
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(gameObject);    
    }
}
