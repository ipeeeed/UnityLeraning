using UnityEngine;

public class PlayerControle : MonoBehaviour
{
    private float horizontal; // movimento
    [SerializeField] private float speed = 6f; // valocidade
    [SerializeField] private float jumpingForce = 17f; // força do pulo
    [SerializeField] private bool isFacingRight = true; // virado para a direita
    [SerializeField] private bool isJumping = false; // pulando
    [SerializeField] private Rigidbody2D rb; // fisica

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        
        if (isJumping == true && rb.velocity.y < 0.1 && rb.velocity.y > -0.1)
        {
            isJumping = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (isJumping == false)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingForce);
                isJumping = true;
            }
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
