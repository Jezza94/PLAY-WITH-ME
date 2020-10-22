using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hannah : MonoBehaviour
{
    private float moveX;
    private float moveY;
    CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    public int speed;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0.0f);
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
