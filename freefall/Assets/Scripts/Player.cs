using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Keycodes
    public KeyCode UpKey;
    public KeyCode DownKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode RunKey;
    public KeyCode JumpKey;

    private float moveSpeed;
    private float walkSpeed=0.1f;
    private float runSpeed=0.3f;
    private float jumpForce=10f;
    
    
    private Rigidbody rb;
    
    
    void Update()
    {
        Move();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Move()
    {
        //jump
        if (Input.GetKey(JumpKey)){rb.AddForce(Vector3.up*jumpForce);}
        
        //check if walk or run
        if (Input.GetKey(RunKey)){moveSpeed = runSpeed;}
        else{moveSpeed = walkSpeed;}
        
        //move on input
        Vector3 newTransform = new Vector3();
        if (Input.GetKey(UpKey))
        {
            newTransform+=Vector3.forward*moveSpeed;
        }
        if (Input.GetKey(DownKey))
        {
            newTransform-=Vector3.forward*moveSpeed;
        }       
        if (Input.GetKey(LeftKey))
        {
            newTransform+=Vector3.left*moveSpeed;
        }       
        if (Input.GetKey(RightKey))
        {
            newTransform-=Vector3.left*moveSpeed;
        }
        transform.position += newTransform;
    }
    
}
