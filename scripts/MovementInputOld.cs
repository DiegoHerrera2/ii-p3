using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInputOld : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xAxisVelocity = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yAxisVelocity = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xAxisVelocity, yAxisVelocity, 0);
    }
}