using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroBuddyMovement : MonoBehaviour{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    bool didCrouch = false;
    bool didJump = false;

    public float runSpeed = 40;
  
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        didJump = Input.GetButtonDown("Jump");
    }

    void FixedUpdate(){
        controller.Move(horizontalMove * Time.fixedDeltaTime, didCrouch, didJump);
        didJump = false;
    }

}
