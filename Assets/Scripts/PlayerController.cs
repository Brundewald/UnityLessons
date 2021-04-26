using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _speed = 5;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _rotateSpeed = 50;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        var speed = Vector3.forward * _direction.z * _speed * Time.deltaTime;
        transform.Translate(speed);

        var rotate = Vector3.up * _direction.x * _rotateSpeed * Time.deltaTime;
        transform.Rotate(rotate);
    }
}
