using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody2D rigid;

    [Header("Specs")]
    [SerializeField] float jumpPower;
    [SerializeField] float moveSpeed;

    private void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        transform.right = rigid.velocity + Vector2.right * moveSpeed;
    }
    private void Jump()
    {
        // 가속도 방식
        //rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        // 속도지정 방식 - 정해진 속도로 세팅
        rigid.velocity = Vector2.up * jumpPower;
    }

    private void OnJump(InputValue Value)
    {
        if (Value.isPressed)
        {
            Jump();
        }
    }
}
