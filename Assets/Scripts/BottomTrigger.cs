using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    private void OnTriggerEnter(Collider other)
    {
        var hero = other.GetComponent<BoxCollider>();

        if (hero != null) 
        {
            other.transform.position = _gameObject.transform.position;
        }
    }   

}
