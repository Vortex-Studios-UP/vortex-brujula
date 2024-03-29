using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegacyPlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;

    public float RunSpeed = 40f;

    bool jump = false;
    bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = (Input.GetAxisRaw("Horizontal") * RunSpeed);

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
