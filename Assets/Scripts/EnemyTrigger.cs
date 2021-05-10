using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] GameObject _Pedal;
    [SerializeField] GameObject _firstObj;
    [SerializeField] GameObject _secondObj;

    private void OnTriggerEnter(Collider other)
    {
        var hero = other.GetComponent<BoxCollider>();

        if (hero != null)
        {
            _firstObj.SetActive(true);
            _secondObj.SetActive(true);
            Destroy(_Pedal);
        }        
    }
}
