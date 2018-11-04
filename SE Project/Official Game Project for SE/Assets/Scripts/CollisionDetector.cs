using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + "Has Exited");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + "Has Stayed");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name + "The Object Has Collidied With you!");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.transform.name + "The Object has stopped.");
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.transform.name + "The Object Left.. I guess?");
    }
}
