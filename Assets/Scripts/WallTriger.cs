using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTriger : MonoBehaviour
{
    
    [SerializeField] GameObject _Pedal;
    [SerializeField] GameObject _wall;
    [SerializeField] GameObject _helper;

    private void OnTriggerEnter(Collider other)
    {
        var hero = other.GetComponent<BoxCollider>();

        if (hero != null)
        {
            if (_wall.activeInHierarchy == false) 
            {
                _wall.SetActive(true);
            }
            if (_helper.activeInHierarchy == false)
            {
                _helper.SetActive(true);
            }
            Destroy(_Pedal);
        }        
    }
}
