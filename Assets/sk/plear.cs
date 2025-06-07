using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plear : MonoBehaviour
{
    public float moveSpeed = 10f;
    private float _directionMove;
    private Rigidbody2D _playerRb;
    bool canJump = true;
        public float jumpForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _directionMove = Input.GetAxis("Horizontal") * moveSpeed;
    }
    void FixedUpdate()
    {
        Vector2 velocity = _playerRb.velocity;
        velocity.x = _directionMove;
        _playerRb.velocity = velocity;

        if (Input.GetKey(KeyCode.Space) && canJump)
        {
            _playerRb.velocity = Vector2.up * jumpForce;
        }
    }


    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Ground"))
        {
            canJump = true;
             
        }
    }
}