using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move1 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;  
    [SerializeField] private Text scoreText;
    [SerializeField] private Text thornText;
    private float moveHorizontal;
    private float radius = 0.3f;
    private Rigidbody2D rb;
    private bool turnRight;
    private bool isGrounded;
    private Animator anim;
    private  int coin;
    private  int mace;
    private Vector3 Axis;
    
    void Start()

    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, ground);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {    
            rb.velocity = Vector2.up * jumpForce;
            anim.SetTrigger("Jump"); 
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10;
        }
        else
        {
            speed = 5;
        }
        if (moveHorizontal != 0)
        {
            anim.SetBool("Run", true);
        }
        else anim.SetBool("Run", false);
    }   

    private void FixedUpdate()
    {
        moveHorizontal=Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        if (!turnRight && moveHorizontal < 0)
        {
            Turn();
        }   
        else if (turnRight && moveHorizontal > 0)
        {
            Turn(); 
        }   
    }

    private void Turn()
    {
        turnRight = !turnRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            coin += 1;
            scoreText.text = coin.ToString();
            Destroy(collision.gameObject, 1);
        }
        if(collision.CompareTag("BigCoin"))
        {
            coin += 3;
            scoreText.text = coin.ToString();
            Destroy(collision.gameObject, 1);
        }
        if(collision.CompareTag("AntiCoin"))
        {
            coin -= 1;
            mace += 1;
            scoreText.text = coin.ToString();
            thornText.text = mace.ToString();
            Destroy(collision.gameObject);
        }
        if (coin == 6)
        {
            transform.position = Axis;
            transform.position = new Vector3(-6,34,0);
        }
    }

}
