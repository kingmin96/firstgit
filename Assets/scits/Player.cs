using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f; // ������Ʈ�� ������ �� ������ ���� ����
    private Rigidbody2D rb; // Rigidbody2D ������Ʈ�� ������ ����

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D ������Ʈ ��������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // �����̽��ٸ� ������ ��
        {
            Jump(); // ���� �Լ� ȣ��
        }
    }

    void Jump()
    {
        if (rb != null)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f); // y�� ������ �ӵ��� �ʱ�ȭ�Ͽ� �ߺ� ���� ����
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // y�� �������� ���� ���� ����
        }
    }
}
