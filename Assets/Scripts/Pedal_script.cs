using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal_script : MonoBehaviour
{
    [SerializeField] GameObject _firstPedal;
    [SerializeField] GameObject _secondPedal;
    

    private void OnTriggerEnter(Collider other)
    {
        var hero = other.GetComponent<BoxCollider>();

        if (hero != null)
        {
            _secondPedal.SetActive(true);
          
            Destroy(_firstPedal);
        }

        if (_secondPedal.name == "Walls_1" || _secondPedal.name == "Walls_2") 
        {
            Destroy(_secondPedal);
        }
    } 
}
