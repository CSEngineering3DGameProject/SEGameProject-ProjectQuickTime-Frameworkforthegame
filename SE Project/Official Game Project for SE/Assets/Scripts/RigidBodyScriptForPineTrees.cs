using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyScriptForPineTrees : MonoBehaviour {

    public Rigidbody rb;
    Rigidbody m_Rigidbody;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        m_Rigidbody = GetComponent<Rigidbody>();
	}
	
	void PhysicsEnabler()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }

    void PhysicsDisabler()
    {
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }

    void SwitchCollisionDetection()
    {
        
    }
}
