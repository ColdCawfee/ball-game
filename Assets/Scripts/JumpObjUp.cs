using UnityEngine;
using System.Collections;

public class JumpObjUp : MonoBehaviour {
    public float jumpSpeed = 10.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private float jumpTime = 0.0f;
    private float jumpTimeMax = 0.5f;
    private bool isJumping = false;

    void Start() {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
        if (controller.isGrounded) {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= 10.0f;
            if (Input.GetKeyUp(KeyCode.Q)) {
                isJumping = true;
                jumpTime = 0.0f;
            }
        }
        if (isJumping) {
            jumpTime += Time.deltaTime;
            if (jumpTime < jumpTimeMax) {
                moveDirection.y = jumpSpeed;
            } else {
                isJumping = false;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}