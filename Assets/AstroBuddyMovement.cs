using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroBuddyMovement : MonoBehaviour{
    public CharacterController2D controller;
    private Rigidbody2D rigidBody;
    float horizontalMove = 0f;
    bool didCrouch = false;
    bool didJump = true;

    public float runSpeed = 40;
  
    // Start is called before the first frame update
    void Start(){
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        didJump = Input.GetKey("space");
    }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime, didCrouch, didJump);
    }

}
