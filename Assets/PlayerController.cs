using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;
    
    public float maxSpeed = 7.0f;
    public float jumpForce = 200.0f;
    bool isOnGround = false;

    Rigidbody2D playerObject;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementValueX = 1.0f;

        playerObject.velocity = new Vector2 (movementValueX * maxSpeed, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.5f, whatIsGround);

        anim.SetBool("IsOnGround", isOnGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, jumpForce));
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 8.0f;
        } else
        {
            maxSpeed = 4.0f;
        }

    }
}
