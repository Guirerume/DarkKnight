using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;
    public float runSpeed = 40f;
    public bool grounded = true;
    public float health = .3f;
    public int attacks = 0;
    public int maxAttacks = 2;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        Debug.Log(horizontalMove);
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
