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
        _distance = Vector3.Distance(_firstObj.transform.position, _secondObj.transform.position); // ���������� ��������� �� �����

        if (_distance <= 15) // ��������� ��� ����� � �������
        {
            var relativePosition = _secondObj.transform.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            transform.rotation = rotation; // ��������� ��������� ������ ������� �� ������ ������
        }

    }
}
