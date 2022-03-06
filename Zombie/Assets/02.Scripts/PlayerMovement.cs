using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� �Է¿� ���� �÷��̾� ĳ���͸� �����̴� ��ũ��Ʈ
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // �յ� �������� �ӵ�
    public float rotateSpeed = 180f; // �¿� ȸ�� �ӵ�

    private PlayerInput playerInput; // �÷��̾� �Է��� �˷��ִ� ������Ʈ
    private Rigidbody playerRigidbody; // �÷��̾� ĳ������ ������ٵ�
    private Animator playerAnimator; // �÷��̾� ĳ������ �ִϸ�����

    void Start() // ����� ������Ʈ���� ���� ��������
    {
        playerInput = GetComponent<PlayerInput>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    // FixedUpdate�� ���� ���� �ֱ⿡ ���� �����
    // ���� ���� �ֱ⸶�� ������, ȸ��, �ִϸ��̼� ó�� ����
    private void FixedUpdate()
    {
        // ȸ��, ������ ����
        Rotate();
        Move();

        // �Է°��� ���� �ִϸ������� Move �Ķ���Ͱ� ����
        playerAnimator.SetFloat("Move", playerInput.move);
    }

    private void Move() // �Է°��� ���� ĳ���͸� �յڷ� ������
    {
        // ��������� �̵��� �Ÿ� ���
        Vector3 moveDistance = playerInput.move * transform.forward * moveSpeed * Time.deltaTime;
        // ������ٵ� �̿��� ���� ������Ʈ ��ġ ����
        playerRigidbody.MovePosition(playerRigidbody.position + moveDistance);

    }

    private void Rotate() // �Է°��� ���� ĳ���͸� �¿�� ȸ��
    {
        // ��������� ȸ���� ��ġ ���
        float turn = playerInput.rotate * rotateSpeed * Time.deltaTime;
        // ������ٵ� �̿��� ���� ������Ʈ ȸ�� ����
        playerRigidbody.rotation = playerRigidbody.rotation * Quaternion.Euler(0, turn, 0);
    }
}
