using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody _rB;
    
    private Vector3 _jumpDirection = new Vector3(0, 1, 0);
    private float _speed = 5;
    private float _jump = 10;
    private bool _onGround;


    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);
    private const string Jump = nameof(Jump);
    

    

       
    private void Awake()
    {
        _rB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis(Horizontal) * _speed * Time.deltaTime + Vector3.forward * Input.GetAxis(Vertical) * _speed * Time.deltaTime);
           
        if (Input.GetButtonDown(Jump) && _onGround)
        {
           _rB.AddForce(_jumpDirection * _jump, ForceMode.Impulse);
           _onGround = false;
        }   
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground") 
        {
            _onGround = true;
        }
    }


}
