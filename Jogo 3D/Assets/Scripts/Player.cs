using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController characterController;
    [SerializeField] float movementSpeed;
    Vector3 moveVector;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Movement();
    }


    void Movement()
    {
        float horizontal = Input.GetAxis("Horizontal")* movementSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        moveVector = new Vector3(horizontal, 0, vertical);
        characterController.Move(moveVector);

    }
}
