using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] GameObject _firstObj;
    [SerializeField] GameObject _secondObj;
    [SerializeField] GameObject _thirdObj;
    [SerializeField] GameObject _helper;
    [SerializeField] Transform _target;    
    [SerializeField] Transform _patrolePoint1;
    [SerializeField] Transform _patrolePoint2;

    private NavMeshAgent _turret;

    private float _engageDistance = 2f;
    private float _attentionDistance = 10f;
    private float _followDistance = 7f;
    private float _delay = 5f;
    private bool _targetSet = false;

    private void Awake()
    {
        _turret = GetComponent<NavMeshAgent>();
        _firstObj.SetActive(false);
    }

    void Update()
    {
        var distance = Vector3.Distance(_firstObj.transform.position, _secondObj.transform.position); // определяем дистанцию до героя
        var wait = Mathf.Repeat(Time.time, 15f);

        if (distance <= _attentionDistance && _secondObj.GetComponent<Renderer>().material.color != Color.red) // проверяем что герой в радиусе
        {
            Attention();
        }
        if (distance <= _followDistance && _secondObj.GetComponent<Renderer>().material.color != Color.red)
        {    
            Follow();
        }
        if (distance <= _engageDistance && _secondObj.GetComponent<Renderer>().material.color != Color.red) // проверяем что герой в радиусе
        {
            Engage();
        }
        else
        {
            Patrole();
        }
    }

    private void Patrole()
    {
        float complete = 1;

        if ((_turret.pathEndPosition - _turret.transform.position).magnitude <= complete)
        { 
            _turret.SetDestination(_patrolePoint2.position); 
        }            
        
        if ((_turret.pathEndPosition - _turret.transform.position).magnitude <= complete)
        { 
            _turret.SetDestination(_patrolePoint1.position); 
        }           
        
        if (_targetSet == false)
        {
            _turret.SetDestination(_patrolePoint1.position);
            _targetSet = true;
        }
    }

    private void Follow() 
    {      
        _turret.SetDestination(_target.position);
    }

    private void Attention() 
    {
        var distance = Vector3.Distance(_firstObj.transform.position, _secondObj.transform.position);
        var relativePosition = _secondObj.transform.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.rotation = rotation; // позволяет направить взгляд объекта на другой объект
        if (distance > _engageDistance && distance < _attentionDistance)
        {
            _targetSet = false;
        }

    }

    private void Engage()
    {
            var relativePosition = _secondObj.transform.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            transform.rotation = rotation; // позволяет направить взгляд объекта на другой объект
            _secondObj.transform.position = _thirdObj.transform.position;
            if (_helper.activeInHierarchy == false)
                _helper.SetActive(true);       
    }
}

