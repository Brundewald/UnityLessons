using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideChanger : MonoBehaviour
{
    [SerializeField] Renderer _heroRenderer;

    private Vector3 _rV = new Vector3(1, 0, 1);
    private float _rotationSpeed = 100;

    private void OnTriggerEnter(Collider other)
    {
        _heroRenderer.material.color = Color.red;        
    }

    private void Update()
    {
        transform.Rotate(_rV * _rotationSpeed * Time.deltaTime);
    }
}
