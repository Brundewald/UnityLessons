using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float _speed = 5;
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _rotateSpeed = 50;
    [SerializeField] private float _jump = 10;
    [SerializeField] private float _jumpHigh = 1;
    [SerializeField] private Rigidbody rB;
    
    // Start is called before the first frame update
    private void Start()
    {
        rB = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    private void Update()
    {
        _direction.x = Input.GetAxis("Vertical");
        _direction.z = Input.GetAxis("Horizontal");

        var jumpDirection = new Vector3(0, _jumpHigh, 0);

        if (rB.velocity.y == 0)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rB.AddForce(jumpDirection * _jump, ForceMode.Impulse);
            }
        }
    }

    private void FixedUpdate()
    {
        var speed = Vector3.right * _direction.x * _speed * Time.deltaTime;
        transform.Translate(speed);

        var rotate = Vector3.up * _direction.z * _rotateSpeed * Time.deltaTime;
        transform.Rotate(rotate);

        
    }
}
