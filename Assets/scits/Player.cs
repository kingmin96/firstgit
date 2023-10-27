using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f; // 오브젝트가 점프할 때 가해질 힘의 세기
    private Rigidbody2D rb; // Rigidbody2D 컴포넌트를 저장할 변수

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트 가져오기
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 스페이스바를 눌렀을 때
        {
            Jump(); // 점프 함수 호출
        }
    }

    void Jump()
    {
        if (rb != null)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f); // y축 방향의 속도를 초기화하여 중복 점프 방지
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // y축 방향으로 힘을 가해 점프
        }
    }
}
