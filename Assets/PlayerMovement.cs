using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

        public float speed = 12f;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0f, z);
        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.z);
        animator.SetFloat("Speed", move.sqrMagnitude);
        controller.Move(move * speed * Time.deltaTime);

    }
    void FixedUpdate()
    {

    }
}
