using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Soy " + gameObject.name + " y acabo de chocar con " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider collider) {
        Debug.Log("Soy " + gameObject.name + " y acabo de chocar con " + collider.gameObject.name);
    }
}
