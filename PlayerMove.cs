using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private GameObject player;   //(操作)移動したいオブジェクトを設定
    private Rigidbody2D rb;
    [SerializeField]Animator animator = null;

    private static float PlayerX = 0;
    private static float PlayerY = 0;

    void Start()
    {
        player = GameObject.Find("主人公");
        rb = this.transform.GetComponent<Rigidbody2D>();
        transform.position = new Vector2(PlayerX, PlayerY);
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        rb.velocity = new Vector2(0, 0);
        animator.speed = 0f;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, 1f);
            animator.speed = 0.7f;
            animator.SetFloat("x", 0);
            animator.SetFloat("y", 1);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -1f);
            animator.speed = 0.7f;
            animator.SetFloat("x", 0);
            animator.SetFloat("y", -1);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(1f, 0);
            animator.speed = 0.7f;
            animator.SetFloat("x", 1);
            animator.SetFloat("y", 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-1f, 0);
            animator.speed = 0.7f;
            animator.SetFloat("x", -1);
            animator.SetFloat("y", 0);
        }
    }
}
