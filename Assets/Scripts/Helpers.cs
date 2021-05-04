using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers : MonoBehaviour
{
    [SerializeField] GameObject _firstObj;
    [SerializeField] GameObject _secondObj;
    
    private float _distance;
   
    void Update()
    {
        _distance = Vector3.Distance(_firstObj.transform.position, _secondObj.transform.position); // определяем дистанцию до героя

        if (_distance <= 15) // проверяем что герой в радиусе
        {
            var relativePosition = _secondObj.transform.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            transform.rotation = rotation; // позволяет направить взгляд объекта на другой объект
        }

    }
}
