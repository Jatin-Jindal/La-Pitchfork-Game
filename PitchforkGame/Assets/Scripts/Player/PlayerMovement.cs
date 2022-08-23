using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1;
    Vector3 direction;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MyInput();
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MyInput()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
    }
    void MovePlayer()
    {
        rb.MovePosition(direction * Time.deltaTime * speed + transform.position);
    }
}
