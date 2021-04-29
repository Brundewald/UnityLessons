using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Look_Controll : MonoBehaviour
{
    [SerializeField] private float _mouseSensitivity = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

    }
}
