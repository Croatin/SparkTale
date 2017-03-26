using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float movementSpeed = 25, jumpHeight = 5;

    public bool canJump;
    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        float movementY = Input.GetAxis("Vertical") * movementSpeed;
        float movementX = Input.GetAxis("Horizontal") * movementSpeed;

        Player.transform.Translate(movementX, 0, movementY);

        if(Input.GetButtonDown("Jump") && canJump)
        {
            Player.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight);
        }
    }
}
