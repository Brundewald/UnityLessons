using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class AudioControl : MonoBehaviour
{
    [SerializeField] private Slider _gain;
    [SerializeField] private AudioSource _audioSource;
    
    private static AudioControl _instance;
    private float _volume;

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

    private void Start()
    {
        _gain.onValueChanged.AddListener(GainChange);       
    }

    private void Update()
    {
        _audioSource.volume = _volume;
    }

    private void GainChange(float value) 
    {
        _volume = value;
        Debug.Log(value);
    }
}
