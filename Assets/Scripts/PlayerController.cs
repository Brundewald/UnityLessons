using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float _speed = 5;
    private Vector3 _direction;
    private Vector3 _rotateVector = new Vector3(0, 1, 0);
    private float _rotateSpeed = 50;
    private float _jump = 10;    
    [SerializeField] private Rigidbody rB;
    private Vector3 _jumpDirection = new Vector3(0, 1, 0);
   

    // Start is called before the first frame update
    private void Start()
    {
        rB = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Jump")&& rB.velocity.y == 0)
         {
           GetComponent<Rigidbody>().velocity = _jumpDirection * _jump;
         }   
    }

    private void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Vertical") * _speed * Time.deltaTime, 0, 0);
        
        transform.Rotate(0, Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime, 0);
    }
}
