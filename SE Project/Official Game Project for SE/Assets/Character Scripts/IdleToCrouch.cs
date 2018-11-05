using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToCrouch : MonoBehaviour {
    public Animator animator;
    public float inputX;
    public float inputY;
    public float Blend = 1f;
    // Use this for initialization
    void Start() {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("space"))
        {
            inputY = inputY - 1f;
            animator.SetFloat("inputY", inputY);
        }
    }
}
