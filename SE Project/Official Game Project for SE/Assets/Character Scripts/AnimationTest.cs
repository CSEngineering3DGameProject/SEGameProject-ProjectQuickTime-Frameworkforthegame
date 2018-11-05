using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour {

    public Animator anim;
    public float Test;
    private Rigidbody rb;
    private float jumpSpeed = 5;
    private bool onGround = true;
    private float verticalVelocity;
    private float gravity = 14f;
    public float speed = 1000000f;
    public float rotationspeed = 100f;
	void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        CharacterController controller = GetComponent<CharacterController>();
       
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown("space"))
        {
            anim.SetTrigger("test");
            rb.AddForce(Vector3.up, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("w"))
        {
            anim.SetBool("running", true);
            transform.Translate(0f, 0f, 10f);
        }
        if (Input.GetKeyDown("s"))
        {
            anim.SetTrigger("Crouch");
        }
        if(Input.GetKeyDown("b"))
        {
            anim.SetTrigger("Dancing");
        }
        if (Input.GetKeyDown("t"))
        {
            anim.SetBool("isIdle", true);
        }
       
	}
}
