using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingScript : MonoBehaviour
{

    float speed = 40;
    float rotation = 80;
    float rot = 0f;
    float Gravity = 40;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator anim;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        GetInput();
    }
    void Movement()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("running", true);
                anim.SetInteger("New", 1);
                anim.SetTrigger("Running");
                moveDir = new Vector3(0, 0, 1);
                moveDir *= speed;
                moveDir = transform.TransformDirection(moveDir);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                anim.SetBool("running", false);
                anim.SetInteger("New", 0);
                moveDir = new Vector3(0, 0, 0);
            }

        }
        rot += Input.GetAxis("Horizontal") * rotation * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        moveDir.y -= Gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    void GetInput()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                anim.SetInteger("New", 2);
              

            }
            if(Input.GetKeyUp(KeyCode.Space))
            {
                anim.SetInteger("New", 0);
            }
        
        }
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                anim.SetInteger("New", 3);
                anim.SetTrigger("Walk");
                moveDir = new Vector3(0, 0, -1);

            }
            rot += Input.GetAxis("Horizontal") * rotation * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rot, 0);
            moveDir.y -= Gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime);

        }
    }
}

