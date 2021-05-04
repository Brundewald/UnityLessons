using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_behavior : MonoBehaviour
{
    [SerializeField] GameObject _firstObj;
    [SerializeField] GameObject _secondObj;
    [SerializeField] GameObject _thirdObj;
    [SerializeField] GameObject _helper;


    private float _distance;

    void Update()
    {
        _distance = Vector3.Distance(_firstObj.transform.position, _secondObj.transform.position); // ���������� ��������� �� �����

        if (_distance <= 10 && _secondObj.GetComponent<Renderer>().material.color != Color.red) // ��������� ��� ����� � �������
        {
            var relativePosition = _secondObj.transform.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            transform.rotation = rotation; // ��������� ��������� ������ ������� �� ������ ������
        }
        if (_distance <= 5 && _secondObj.GetComponent<Renderer>().material.color != Color.red) // ��������� ��� ����� � �������
        {
            var relativePosition = _secondObj.transform.position - transform.position;
            var rotation = Quaternion.LookRotation(relativePosition);
            transform.rotation = rotation; // ��������� ��������� ������ ������� �� ������ ������
            _secondObj.transform.position = _thirdObj.transform.position;
            _helper.SetActive(true);
        }
    }
}
