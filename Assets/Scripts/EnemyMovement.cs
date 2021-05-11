using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))] //позволяет добавить компонент в объект, даже если его нет.

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent _agent;


    private void Awake()
    {
        
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
    }
}