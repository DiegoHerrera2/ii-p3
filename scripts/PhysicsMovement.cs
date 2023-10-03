using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        rb.AddForce(playerInput * movementSpeed);
    }
}
