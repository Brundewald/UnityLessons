using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Vector3 _vectorFirst;
    [SerializeField] Vector3 _vectorSecond;
    [SerializeField] Transform _transformObject;

    private float _distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        //var rotation = Quaternion.Angle(_transformObject.rotation, transform.rotation);
        //Debug.LogWarning(rotation); //определение угла вращения.
        var relativePosition = _transformObject.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.rotation = rotation; // позволяет направить взгляд объекта на другой объект
        //var movePosition = ;
        ////var a = _vectorFirst.normalized;
        //Debug.Log(Vector3.Dot(_vectorFirst, _vectorSecond)); // Скалярное произведение


        //Debug.Log(Vector3.Cross(_vectorFirst.normalized, _vectorSecond.normalized)); // Векторное произведение
        //_distance = Vector3.Distance(_vectorFirst, transform.position);
        //Debug.Log(_distance);

        //_distance = (_vectorFirst - transform.position).magnitude;
        //Debug.Log(_distance);
    }
}
