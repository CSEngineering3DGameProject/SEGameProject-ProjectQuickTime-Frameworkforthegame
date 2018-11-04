using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour {

    public Animator anim;
    public float Test;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space"))
        {
            anim.SetFloat("Test", Test - 1);
        }
        if(Input.GetKey("w")) 
        {
            anim.SetFloat("Test", Test + 1);
            transform.Translate(0,0,5f);
        }
        if(Input.GetKey("s"))
        {
            transform.Translate(0, 0, -5f);
        }
	}
}
