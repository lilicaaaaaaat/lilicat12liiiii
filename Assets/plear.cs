using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plear : MonoBehaviour
{
    public float moveSpeed = 10f;
    private float _directionMove;
    private Rigidbody2D _playerRb;
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

    }

    public float minJump = 15f, maxJump = 30f;
    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Ground"))
        {
            float jump = Random.Range(minJump, maxJump);
            Rigidbody2D player = obj.gameObject.GetComponent<Rigidbody2D>();
            player.velocity = Vector2.up * jump;
        }
    }
}