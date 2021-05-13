using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] GameObject _Pedal;
    [SerializeField] GameObject _enemy;

    private void OnTriggerEnter(Collider other)
    {
        var hero = other.GetComponent<BoxCollider>();

        if (hero != null)
        {
            if (_enemy.activeInHierarchy == false) 
            {
                _enemy.SetActive(true);
            }
            
            Destroy(_Pedal);
        }        
    }
}
