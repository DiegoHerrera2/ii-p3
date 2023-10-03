using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) Debug.Log("Presionada tecla arriba, resultado = " + Input.GetAxis("Horizontal") * velocity); 
        if (Input.GetKey(KeyCode.DownArrow)) Debug.Log("Presionada tecla abajo, resultado = " + Input.GetAxis("Horizontal") * velocity); 
        if (Input.GetKey(KeyCode.LeftArrow)) Debug.Log("Presionada tecla izquierda, resultado = " + Input.GetAxis("Horizontal") * velocity); 
        if (Input.GetKey(KeyCode.RightArrow)) Debug.Log("Presionada tecla derecha, resultado = " + Input.GetAxis("Horizontal") * velocity); 
    }
}
