using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
   
{
    private float speed = 20f;
    private float turnSpeed = 30f;
    private float verticalInput;
    private float zMax = 450f;

    void Start()
    { transform.position = new Vector3(0, 0, 0);}

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed * verticalInput);
        if (transform.position.z >= zMax)
        { 
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
    }
}
