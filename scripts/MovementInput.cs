using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
        transform.Translate(0, 0, movement);
        Debug.DrawRay(transform.position, transform.forward * 10, Color.green);
    }
}

