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
        // ���ӵ� ���
        //rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        // �ӵ����� ��� - ������ �ӵ��� ����
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
