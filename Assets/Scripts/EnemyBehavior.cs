using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] GameObject _firstObj;
    [SerializeField] GameObject _secondObj;
    [SerializeField] GameObject _thirdObj;
    [SerializeField] GameObject _helper;
    private float _engageDistance = 5f;
    private float _attentionDistance = 10f;
        

    void Update()
    {
        var distance = Vector3.Distance(_firstObj.transform.position, _secondObj.transform.position); // определяем дистанцию до героя

        if (distance <= _attentionDistance && _secondObj.GetComponent<Renderer>().material.color != Color.red) // проверяем что герой в радиусе
        {
            var relativePosition = _secondObj.transform.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            transform.rotation = rotation; // позволяет направить взгляд объекта на другой объект
        }
        if (distance <= _engageDistance && _secondObj.GetComponent<Renderer>().material.color != Color.red) // проверяем что герой в радиусе
        {
            var relativePosition = _secondObj.transform.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            transform.rotation = rotation; // позволяет направить взгляд объекта на другой объект
            _secondObj.transform.position = _thirdObj.transform.position;
            if (_helper.activeInHierarchy == false)
            _helper.SetActive(true);
        }
    }
}
