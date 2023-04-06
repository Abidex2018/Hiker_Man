using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
        
    private float directionX = 0f;
    [SerializeField]private float moveSpeed = 7f;
    [SerializeField]private float jumpForce = 14f;

    // Start is called before the first frame update
    private void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {

        directionX = Input.GetAxisRaw("Horizontal");

        rigidbody2D.velocity = new Vector2(directionX * moveSpeed, rigidbody2D.velocity.y);

        if (Input.GetButtonDown("Jump") || Input.GetKeyDown("up"))
        {
            rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, jumpForce, rigidbody2D.velocity.y);
        }

        UpdateAnimator();



    }

    private void UpdateAnimator()
    {
        if (directionX > 0f)
        {
            animator.SetBool("running", true);
            spriteRenderer.flipX = false;
        }
        else if (directionX < 0f)
        {
            animator.SetBool("running", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.SetBool("running", false);
        }
    }
}
