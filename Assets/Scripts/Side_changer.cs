using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side_changer : MonoBehaviour
{
    [SerializeField] GameObject _Hero;

    private Vector3 _rV = new Vector3(1, 0, 1);
    private float _rotationSpeed = 100;

    private void OnTriggerEnter(Collider other)
    {
        _Hero.GetComponent<Renderer>().material.color = Color.red;        
    }

    private void Update()
    {
        transform.Rotate(_rV * _rotationSpeed * Time.deltaTime);
    }
}
